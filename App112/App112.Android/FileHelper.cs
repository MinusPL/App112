using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using Xamarin.Forms;
using App112.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace App112.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}