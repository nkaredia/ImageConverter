/*
    NOTE: This class is only a part of a project
*/
/*
    Author : Noorsil Karedia
    Index  : Comments with (/**/)  /*
             contains general information for class, variables, and methods
             Comments with ( // ) 
             contains information for that specific statement on the line
                
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

/*
    This class is used in a project called Image Converter which converts 
    images to various image formats
*/
namespace ImageConverter   
{
    
    /*
        File Fetcher class allows user to open file or folder dialog to select multiple
        image files or folder containing image files.
    */
    class FileFetcher
    {
        private OpenFileDialog open; 
        private FolderBrowserDialog folder;
        private String absolutePath;        // absolutePath contains path to store all images after converted 
        /*
            NOTE: String[] filename, extension, FileNameWithPath are parallel arrays in nature
        */
        private String[] filename;          // stores file names that are selected by user
        private String[] extension;         // stores file extension for all files stored in filename array. 
        private String[] FileNameWithPath;  // stores full path of all files
        
                                           

        /*
            Constructor constructs all objects required and sets all strings to null
        */
        public FileFetcher()
        {
            open = new OpenFileDialog();
            folder = new FolderBrowserDialog();
            filename = null;
            absolutePath = null;
            extension = null;
            FileNameWithPath = null;
        }

        
        /*
            fetch method process opening and close file or folder dialog and extracts all
            components.
        */
        public String fetch(String type)
        {
            String pth = null;                          // Temporary reference to store a single file path
            if (type.ToLower() == "files")              // If user select to open file dialog
            {
                ArrayList FileName = new ArrayList();   // Temporary storing of filenames
                ArrayList Ext = new ArrayList();        // Temporary storing of extension
                
                // sets extension filter for file dialog 
                open.Filter = "png files|*.png|jpg files|*.jpg|bmp files|*.bmp|gif files|*.gif" +
                    "|wmf files|*.wmf|emf files|*.emf|tiff files|*.tif;*.tiff|icon files|*.ico" +
                    "|All Graphic Types|*.png;*.jpg;*.bmp;*.gif;*.wmf;*.emf;*.tif;*.tiff;*.ico"; 
                open.FilterIndex = 1;
                open.Multiselect = true;
                open.Title = "Select Multiple Files";
                
                /*
                    if user selects atleast one file 
                */
                if (open.ShowDialog() == DialogResult.OK)
                {
                    FileNameWithPath = open.FileNames;                            // Store all files in array
                    absolutePath = Path.GetDirectoryName(FileNameWithPath[0]);    // store absolute path for all files
                    pth = Path.GetDirectoryName(FileNameWithPath[0]);             // Temporary store absolute path
                    extractImageFiles(FileNameWithPath);                          // <-- Member function -->
                }

            }
            else if (type.ToLower() == "folder")  /*  if user selects folder dialog  */
            {
                folder.Description = "Select a Folder in which Multiple Image Files Resides";
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    pth = folder.SelectedPath;                                   // Temporary store absolute path
                    this.absolutePath = folder.SelectedPath;                     // Store Absolute path for selected folder
                    String[] f = Directory.GetFiles(folder.SelectedPath);        // Temporary Store all files from folder
                    extractImageFiles(f);                                        // <-- Member function -->
                }
            }
            return pth; // return absolute path
        }


        /*
            Extract Image files if user has selected folder from folder dialog
            and stores in an array
        */
        private void extractImageFiles(String[] files)
        {
            ArrayList imgFiles = new ArrayList();                   // Temporary stores image files
            ArrayList FileName = new ArrayList();                   // Temporary stores filenames
            ArrayList Ext = new ArrayList();                        // Temporary stores extension of files
            for (int i = 0; i < files.Length; i++)
            {
                /*
                    Check if filepath ends with following extension then add it in list
                */
                if (files[i].EndsWith(".png") || files[i].EndsWith(".jpg") || files[i].EndsWith(".bmp") ||
                    files[i].EndsWith(".gif") || files[i].EndsWith(".wmf") || files[i].EndsWith(".tif") ||
                    files[i].EndsWith(".ico") || files[i].EndsWith(".emf") || files[i].EndsWith(".tiff"))
                {
                    imgFiles.Add(files[i]);
                    extractFilenameAndExtension(files[i], FileName, Ext);    // <-- Member function -->
                }
            }
            
            /*
                Store filename, extension,and path to their respective private member variables
            */
            this.FileNameWithPath = (String[])imgFiles.ToArray(typeof(string));
            this.filename = (String[])FileName.ToArray(typeof(string));
            this.extension = (String[])Ext.ToArray(typeof(string));
        }


        /*
            This method extracts filename and extension from a complete path
            and adds the values to list (2nd and 3rd parameter)
        */
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


        /*
            returns all file WITHOUT respected path
        */
        public String[] getFileNames()
        {
            return this.filename;
        }

        /*
            returns all extension of files
        */
        public String[] getExtension()
        {
            return this.extension;
        }


        /*
            return array of files with respected path
        */
        public String[] getFileWithPath()
        {
            return this.FileNameWithPath;
        }


        /*
            return true if there is no file stored in the current object
        */
        public bool isEmpty()
        {
            bool ret = false;
            if (filename == null && extension == null && FileNameWithPath == null && absolutePath == null)
                ret = true;
            return ret;
        }
    }
}
