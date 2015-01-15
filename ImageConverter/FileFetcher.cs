using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace ImageConverter
{
    class FileFetcher
    {
        private OpenFileDialog open;
        private FolderBrowserDialog folder;
        private String[] filename;
        private String absolutePath;
        private String[] extension;
        private String[] FileNameWithPath;

        public FileFetcher()
        {
            open = new OpenFileDialog();
            folder = new FolderBrowserDialog();
            filename = null;
            absolutePath = null;
            extension = null;
            FileNameWithPath = null;
        }


        public String fetch(String type)
        {
            String pth = null;
            if (type.ToLower() == "files")
            {
                ArrayList FileName = new ArrayList();
                ArrayList Ext = new ArrayList();
                open.Filter = "png files|*.png|jpg files|*.jpg|bmp files|*.bmp|gif files|*.gif" +
                    "|wmf files|*.wmf|emf files|*.emf|tiff files|*.tif;*.tiff|icon files|*.ico" +
                    "|All Graphic Types|*.png;*.jpg;*.bmp;*.gif;*.wmf;*.emf;*.tif;*.tiff;*.ico";
                open.FilterIndex = 1;
                open.Multiselect = true;
                open.Title = "Select Multiple Files";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileNameWithPath = open.FileNames;
                    absolutePath = Path.GetDirectoryName(FileNameWithPath[0]);
                    pth = Path.GetDirectoryName(FileNameWithPath[0]);
                    extractImageFiles(FileNameWithPath);
                }

            }
            else if (type.ToLower() == "folder")
            {
                folder.Description = "Select a Folder in which Multiple Image Files Resides";
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    pth = folder.SelectedPath;
                    this.absolutePath = folder.SelectedPath;
                    String[] f = Directory.GetFiles(folder.SelectedPath);
                    extractImageFiles(f);
                }
            }
            return pth;
        }

        private void extractImageFiles(String[] files)
        {
            ArrayList imgFiles = new ArrayList();
            ArrayList FileName = new ArrayList();
            ArrayList Ext = new ArrayList();
            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(".png") || files[i].EndsWith(".jpg") || files[i].EndsWith(".bmp") ||
                    files[i].EndsWith(".gif") || files[i].EndsWith(".wmf") || files[i].EndsWith(".tif") ||
                    files[i].EndsWith(".ico") || files[i].EndsWith(".emf") || files[i].EndsWith(".tiff"))
                {
                    imgFiles.Add(files[i]);
                    extractFilenameAndExtension(files[i], FileName, Ext);
                }
            }
            this.FileNameWithPath = (String[])imgFiles.ToArray(typeof(string));
            this.filename = (String[])FileName.ToArray(typeof(string));
            this.extension = (String[])Ext.ToArray(typeof(string));
        }

        private void extractFilenameAndExtension(String filePath, ArrayList AddfileName, ArrayList Addext)
        {
            String[] splitPath = filePath.Split('\\');
            String[] splitNameAndExtension = splitPath[splitPath.Length - 1].Split('.');
            String concatName = null;
            Addext.Add("."+splitNameAndExtension[splitNameAndExtension.Length - 1]);
            for (int j = 0; j < splitNameAndExtension.Length - 1; j++)
            {
                concatName += splitNameAndExtension[j];
                if (j < splitNameAndExtension.Length - 2)
                    concatName += ".";
            }
            AddfileName.Add(concatName);
        }

        public String[] getFileNames()
        {
            return this.filename;
        }

        public String[] getExtension()
        {
            return this.extension;
        }

        public String[] getFileWithPath()
        {
            return this.FileNameWithPath;
        }

        public bool isEmpty()
        {
            bool ret = false;
            if (filename == null && extension == null && FileNameWithPath == null && absolutePath == null)
                ret = true;
            return ret;
        }
    }
}
