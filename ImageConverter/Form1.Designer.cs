using System.Windows.Forms;
using System.Drawing;
using System;

namespace ImageConverter
{
    partial class ImageConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.path = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folder = new System.Windows.Forms.RadioButton();
            this.files = new System.Windows.Forms.RadioButton();
            this.console = new System.Windows.Forms.RichTextBox();
            this.panelMsg = new System.Windows.Forms.Panel();
            this.message = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resizePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightField = new System.Windows.Forms.NumericUpDown();
            this.height = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthField = new System.Windows.Forms.NumericUpDown();
            this.wmf = new System.Windows.Forms.RadioButton();
            this.emf = new System.Windows.Forms.RadioButton();
            this.icon = new System.Windows.Forms.RadioButton();
            this.gif = new System.Windows.Forms.RadioButton();
            this.convertBut = new System.Windows.Forms.Button();
            this.bmp = new System.Windows.Forms.RadioButton();
            this.jpg = new System.Windows.Forms.RadioButton();
            this.png = new System.Windows.Forms.RadioButton();
            this.dropSelect = new System.Windows.Forms.ComboBox();
            this.tiff = new System.Windows.Forms.RadioButton();
            this.minimize = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMsg.SuspendLayout();
            this.panel3.SuspendLayout();
            this.resizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).BeginInit();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.path.Location = new System.Drawing.Point(150, 12);
            this.path.Name = "path";
            this.path.ReadOnly = true;
            this.path.Size = new System.Drawing.Size(442, 20);
            this.path.TabIndex = 0;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.openFile.FlatAppearance.BorderSize = 0;
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Image = global::ImageConverter.Properties.Resources.icon;
            this.openFile.Location = new System.Drawing.Point(595, 5);
            this.openFile.Margin = new System.Windows.Forms.Padding(0);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(40, 33);
            this.openFile.TabIndex = 1;
            this.openFile.TabStop = false;
            this.openFile.UseMnemonic = false;
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.folder);
            this.panel1.Controls.Add(this.files);
            this.panel1.Controls.Add(this.path);
            this.panel1.Controls.Add(this.openFile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 45);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // folder
            // 
            this.folder.AutoSize = true;
            this.folder.Location = new System.Drawing.Point(90, 15);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(54, 17);
            this.folder.TabIndex = 3;
            this.folder.TabStop = true;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            // 
            // files
            // 
            this.files.AutoSize = true;
            this.files.Location = new System.Drawing.Point(38, 15);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(46, 17);
            this.files.TabIndex = 2;
            this.files.TabStop = true;
            this.files.Text = "Files";
            this.files.UseVisualStyleBackColor = true;
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(194, 51);
            this.console.Name = "console";
            this.console.ReadOnly = true;
            this.console.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.console.Size = new System.Drawing.Size(481, 378);
            this.console.TabIndex = 3;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panelMsg
            // 
            this.panelMsg.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelMsg.Controls.Add(this.minimize);
            this.panelMsg.Controls.Add(this.close);
            this.panelMsg.Controls.Add(this.message);
            this.panelMsg.Location = new System.Drawing.Point(0, 444);
            this.panelMsg.Name = "panelMsg";
            this.panelMsg.Size = new System.Drawing.Size(682, 32);
            this.panelMsg.TabIndex = 4;
            this.panelMsg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMsg_MouseDown);
            this.panelMsg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMsg_MouseMove);
            this.panelMsg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMsg_MouseUp);
            // 
            // message
            // 
            this.message.AllowDrop = true;
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(300, 10);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 0;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.resizePanel);
            this.panel3.Controls.Add(this.wmf);
            this.panel3.Controls.Add(this.emf);
            this.panel3.Controls.Add(this.icon);
            this.panel3.Controls.Add(this.gif);
            this.panel3.Controls.Add(this.convertBut);
            this.panel3.Controls.Add(this.bmp);
            this.panel3.Controls.Add(this.jpg);
            this.panel3.Controls.Add(this.png);
            this.panel3.Controls.Add(this.dropSelect);
            this.panel3.Controls.Add(this.tiff);
            this.panel3.Location = new System.Drawing.Point(4, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 387);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // resizePanel
            // 
            this.resizePanel.Controls.Add(this.label3);
            this.resizePanel.Controls.Add(this.label2);
            this.resizePanel.Controls.Add(this.heightField);
            this.resizePanel.Controls.Add(this.height);
            this.resizePanel.Controls.Add(this.width);
            this.resizePanel.Controls.Add(this.label1);
            this.resizePanel.Controls.Add(this.widthField);
            this.resizePanel.Location = new System.Drawing.Point(4, 76);
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.Size = new System.Drawing.Size(176, 221);
            this.resizePanel.TabIndex = 4;
            this.resizePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(141, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Px";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Px";
            // 
            // heightField
            // 
            this.heightField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heightField.Location = new System.Drawing.Point(76, 74);
            this.heightField.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.heightField.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.heightField.Name = "heightField";
            this.heightField.Size = new System.Drawing.Size(59, 20);
            this.heightField.TabIndex = 4;
            this.heightField.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.ForeColor = System.Drawing.Color.White;
            this.height.Location = new System.Drawing.Point(26, 76);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(38, 13);
            this.height.TabIndex = 3;
            this.height.Text = "Height";
            // 
            // width
            // 
            this.width.AutoSize = true;
            this.width.ForeColor = System.Drawing.Color.White;
            this.width.Location = new System.Drawing.Point(26, 45);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(35, 13);
            this.width.TabIndex = 2;
            this.width.Text = "Width";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resize-Dimensions";
            // 
            // widthField
            // 
            this.widthField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthField.Location = new System.Drawing.Point(76, 43);
            this.widthField.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.widthField.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.widthField.Name = "widthField";
            this.widthField.Size = new System.Drawing.Size(59, 20);
            this.widthField.TabIndex = 0;
            this.widthField.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // wmf
            // 
            this.wmf.AutoSize = true;
            this.wmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wmf.ForeColor = System.Drawing.Color.White;
            this.wmf.Location = new System.Drawing.Point(32, 220);
            this.wmf.Name = "wmf";
            this.wmf.Size = new System.Drawing.Size(50, 17);
            this.wmf.TabIndex = 9;
            this.wmf.TabStop = true;
            this.wmf.Text = "WMF";
            this.wmf.UseVisualStyleBackColor = true;
            this.wmf.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // emf
            // 
            this.emf.AutoSize = true;
            this.emf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emf.ForeColor = System.Drawing.Color.White;
            this.emf.Location = new System.Drawing.Point(32, 197);
            this.emf.Name = "emf";
            this.emf.Size = new System.Drawing.Size(46, 17);
            this.emf.TabIndex = 8;
            this.emf.TabStop = true;
            this.emf.Text = "EMF";
            this.emf.UseVisualStyleBackColor = true;
            // 
            // icon
            // 
            this.icon.AutoSize = true;
            this.icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icon.ForeColor = System.Drawing.Color.White;
            this.icon.Location = new System.Drawing.Point(32, 174);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(50, 17);
            this.icon.TabIndex = 7;
            this.icon.TabStop = true;
            this.icon.Text = "ICON";
            this.icon.UseVisualStyleBackColor = true;
            // 
            // gif
            // 
            this.gif.AutoSize = true;
            this.gif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gif.ForeColor = System.Drawing.Color.White;
            this.gif.Location = new System.Drawing.Point(32, 151);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(41, 17);
            this.gif.TabIndex = 6;
            this.gif.TabStop = true;
            this.gif.Text = "GIF";
            this.gif.UseVisualStyleBackColor = true;
            // 
            // convertBut
            // 
            this.convertBut.FlatAppearance.BorderSize = 2;
            this.convertBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertBut.ForeColor = System.Drawing.Color.White;
            this.convertBut.Location = new System.Drawing.Point(50, 334);
            this.convertBut.Name = "convertBut";
            this.convertBut.Size = new System.Drawing.Size(75, 23);
            this.convertBut.TabIndex = 5;
            this.convertBut.TabStop = false;
            this.convertBut.Text = "Convert";
            this.convertBut.UseVisualStyleBackColor = true;
            this.convertBut.Click += new System.EventHandler(this.convertBut_Click);
            // 
            // bmp
            // 
            this.bmp.AutoSize = true;
            this.bmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bmp.ForeColor = System.Drawing.Color.White;
            this.bmp.Location = new System.Drawing.Point(32, 128);
            this.bmp.Name = "bmp";
            this.bmp.Size = new System.Drawing.Size(47, 17);
            this.bmp.TabIndex = 3;
            this.bmp.TabStop = true;
            this.bmp.Text = "BMP";
            this.bmp.UseVisualStyleBackColor = true;
            // 
            // jpg
            // 
            this.jpg.AutoSize = true;
            this.jpg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jpg.ForeColor = System.Drawing.Color.White;
            this.jpg.Location = new System.Drawing.Point(32, 105);
            this.jpg.Name = "jpg";
            this.jpg.Size = new System.Drawing.Size(44, 17);
            this.jpg.TabIndex = 2;
            this.jpg.TabStop = true;
            this.jpg.Text = "JPG";
            this.jpg.UseVisualStyleBackColor = true;
            // 
            // png
            // 
            this.png.AutoSize = true;
            this.png.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.png.ForeColor = System.Drawing.Color.White;
            this.png.Location = new System.Drawing.Point(32, 82);
            this.png.Name = "png";
            this.png.Size = new System.Drawing.Size(47, 17);
            this.png.TabIndex = 1;
            this.png.TabStop = true;
            this.png.Text = "PNG";
            this.png.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.png.UseVisualStyleBackColor = true;
            // 
            // dropSelect
            // 
            this.dropSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropSelect.FormattingEnabled = true;
            this.dropSelect.Items.AddRange(new object[] {
            "Convert",
            "Resize"});
            this.dropSelect.Location = new System.Drawing.Point(32, 22);
            this.dropSelect.Name = "dropSelect";
            this.dropSelect.Size = new System.Drawing.Size(121, 21);
            this.dropSelect.TabIndex = 0;
            this.dropSelect.TabStop = false;
            this.dropSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tiff
            // 
            this.tiff.AutoSize = true;
            this.tiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tiff.ForeColor = System.Drawing.Color.White;
            this.tiff.Location = new System.Drawing.Point(33, 243);
            this.tiff.Name = "tiff";
            this.tiff.Size = new System.Drawing.Size(46, 17);
            this.tiff.TabIndex = 10;
            this.tiff.TabStop = true;
            this.tiff.Text = "TIFF";
            this.tiff.UseVisualStyleBackColor = true;
            // 
            // minimize
            // 
            this.minimize.Location = new System.Drawing.Point(619, 5);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(28, 23);
            this.minimize.TabIndex = 2;
            this.minimize.Text = "__";
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(647, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 23);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // ImageConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 475);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMsg);
            this.Controls.Add(this.console);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImageConverter";
            this.Text = "nkaredia Image Converter v1.0";
            this.Load += new System.EventHandler(this.ImageConverter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMsg.ResumeLayout(false);
            this.panelMsg.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.resizePanel.ResumeLayout(false);
            this.resizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox console;
        private System.Windows.Forms.Panel panelMsg;
        private System.Windows.Forms.RadioButton folder;
        private System.Windows.Forms.RadioButton files;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.ComboBox dropSelect;
        private System.Windows.Forms.RadioButton bmp;
        private System.Windows.Forms.RadioButton jpg;
        private System.Windows.Forms.RadioButton png;
        private System.Windows.Forms.Panel resizePanel;
        private System.Windows.Forms.NumericUpDown heightField;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown widthField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertBut;
        private System.Windows.Forms.RadioButton emf;
        private System.Windows.Forms.RadioButton icon;
        private System.Windows.Forms.RadioButton gif;
        private System.Windows.Forms.RadioButton tiff;
        private System.Windows.Forms.RadioButton wmf;
        private Button minimize;
        private Button close;
    }
}

