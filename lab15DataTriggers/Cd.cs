using System;
using System.IO;

namespace lab15DataTriggers
{
    public class Cd
    {
        public Cd(string imgTitle, string imgPath)
        {
            ImgTitle = imgTitle;
            ImgPath = imgPath;
        }

        public string ImgTitle { get; set; }
        public string ImgPath { get; set; }
        public bool ImgExisted => File.Exists($"{Environment.CurrentDirectory}\\{ImgPath}");
    }
}
