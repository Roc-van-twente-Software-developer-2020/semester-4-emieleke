using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Opdracht3
{
    class Global
    {
        public static string mediaDirectory = GetMediaDirectory();

        public static string GetMediaDirectory()
        {

            string path = Directory.GetCurrentDirectory();
            string newPath = Path.GetFullPath(Path.Combine(path, @"..\..\..\.."));

            return newPath;
        }
    }
}
