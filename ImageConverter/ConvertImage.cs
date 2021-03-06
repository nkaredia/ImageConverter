﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ImageConverter
{
    class ConvertImage
    {

        private String specialPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\nkImageCoverter";

        public String rename(String file, String ext)
        {
            int count = 1;
            String newFile = file;

            while (File.Exists(specialPath + "\\" + newFile + ext))
            {
                newFile = String.Format("{0}({1})", newFile, count++);
            }
            return newFile;
        }

        public ConvertImage()
        {
            if (!Directory.Exists(specialPath))
            {
                Directory.CreateDirectory(specialPath);
            }
        }


        public void convertImageTo(String filename, String ext, String Image)
        {
            Bitmap image;
            image = new Bitmap(Image);
            switch (ext)
            {
                case ".png":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Png);
                    break;
                case ".jpg":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Jpeg);
                    break;
                case ".bmp":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Bmp);
                    break;
                case ".gif":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Gif);
                    break;
                case ".ico":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Icon);
                    break;
                case ".tif":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Tiff);
                    break;
                case ".wmf":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Wmf);
                    break;
                case ".emf":
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Emf);
                    break;
                default:
                    image.Save(specialPath + "\\" + rename(filename, ext) + ext, ImageFormat.Png);
                    break;
            }

        }

        public void resize(int width, int height, String Image, String filename, String ext)
        {
            Bitmap image;
            image = new Bitmap(Image);
            Bitmap resize;
            resize = new Bitmap(image, new Size(width, height));
            switch (ext)
            {
                case ".jpg":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
                case ".png":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case ".bmp":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Bmp);
                    break;
                case ".gif":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Gif);
                    break;
                case ".ico":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Icon);
                    break;
                case ".wmf":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Wmf);
                    break;
                case ".emf":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Emf);
                    break;
                case ".tif":
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Tiff);
                    break;
                default:
                    resize.Save(specialPath + "\\" + rename(filename, ext) + ext, System.Drawing.Imaging.ImageFormat.Jpeg);
                    break;
            }

        }

        public String getPath()
        {
            return specialPath;
        }
    }
}
