using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ImageConverter
{
    public partial class ImageConverter : Form
    {
        private FileFetcher fileFetcher = null;
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public ImageConverter()
        {
            InitializeComponent();
            files.Checked = true;
            png.Checked = true;

           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = String.Empty;
            //this.ControlBox = false;
            this.close.FlatStyle = FlatStyle.Flat;
            this.close.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = FlatStyle.Flat;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.console.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.console.WordWrap = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = null;
            String[] filePath = null;
            fileFetcher = new FileFetcher();
            if (files.Checked)
            {
                path = fileFetcher.fetch("files");
                filePath = fileFetcher.getFileWithPath();

            }
            else if (folder.Checked)
            {

                path = fileFetcher.fetch("folder");
                filePath = fileFetcher.getFileWithPath();

            }
            if (path != null)
            {
                console.Text = "";
                this.path.Text = path;
                console.AppendText("Loading Files....\n");
                for (int i = 0; i < filePath.Length; i++)
                {
                    console.AppendText(filePath[i] + "\n");
                }
                console.AppendText(filePath.Length + " Files Loaded\n");
                message.Visible = false;
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropSelect.SelectedIndex == 0)
            {
                resizePanel.Visible = false;
            }
            else if (dropSelect.SelectedIndex == 1)
            {
                resizePanel.Visible = true;
            }
        }



        private void convertBut_Click(object sender, EventArgs e)
        {

            if (fileFetcher != null && !fileFetcher.isEmpty())
            {
                ConvertImage con = new ConvertImage();
                String[] FileNames = fileFetcher.getFileNames();
                String[] Extensions = fileFetcher.getExtension();
                String[] Image = fileFetcher.getFileWithPath();
                String ext = null;

                if (dropSelect.SelectedIndex == 0)
                {
                    if (png.Checked)
                    {
                        ext = ".png";
                    }
                    else if (jpg.Checked)
                    {
                        ext = ".jpg";
                    }
                    else if (bmp.Checked)
                    {
                        ext = ".bmp";
                    }
                    else if (gif.Checked)
                    {
                        ext = ".gif";
                    }
                    else if (wmf.Checked)
                    {
                        ext = ".wmf";
                    }
                    else if (emf.Checked)
                    {
                        ext = ".emf";
                    }
                    else if (icon.Checked)
                    {
                        ext = ".ico";
                    }
                    else if (tiff.Checked)
                    {
                        ext = ".tif";
                    }


                    console.AppendText("\nConverting images to " + ext + " format...\n");
                    for (int i = 0; i < FileNames.Length; i++)
                    {
                        console.AppendText("Converted To: \n");
                        con.convertImageTo(FileNames[i], ext, Image[i]);
                        console.AppendText(con.getPath() + "\\" + FileNames[i] + ext + "\n");
                        Application.DoEvents();
                        Thread.Sleep(200);

                    }

                    Application.DoEvents();
                    Thread.Sleep(500);
                    console.AppendText("\nSaving Images...\n");
                    Application.DoEvents();
                    Thread.Sleep(500);

                    console.AppendText("\nDone!\n");

                }
                else if (dropSelect.SelectedIndex == 1)
                {
                    for (int i = 0; i < FileNames.Length; i++)
                    {
                        console.AppendText("Converted To: ");
                        con.resize(Convert.ToInt32(widthField.Value), Convert.ToInt32(heightField.Value), Image[i], FileNames[i], fileFetcher.getExtension()[i]);
                        console.AppendText(con.getPath() + "\\" + FileNames[i] + fileFetcher.getExtension()[i] + "\n");
                        Application.DoEvents();
                        Thread.Sleep(200);
                    }
                    Application.DoEvents();
                    Thread.Sleep(500);
                    console.AppendText("\nSaving Images...\n");
                    Application.DoEvents();
                    Thread.Sleep(500);
                    console.AppendText("\nDone!\n");
                }
            }
            else
            {
                message.Text = "Please Load One or More Images";
                message.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void panelMsg_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panelMsg_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void panelMsg_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void ImageConverter_Load(object sender, EventArgs e)
        {
            this.Text = "nkaredia Image Converter v1.0";
            this.dropSelect.SelectedIndex = 0;
        }


    }
}
