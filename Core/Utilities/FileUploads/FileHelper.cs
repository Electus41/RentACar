using Core.Entities;

using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Core.Utilities.FileUploads
{
    public class FileHelper
    {
        private static string currentDirectory = Environment.CurrentDirectory + @"\wwwroot";
        private static string path = @"\images\";


        public static string Add(IFormFile file)
        {
            var guidName = Guid.NewGuid().ToString();
            var type = Path.GetExtension(file.FileName);
            if (!Directory.Exists(currentDirectory+path))
            {
                Directory.CreateDirectory(currentDirectory+path);                             
            }
            using (FileStream filestream = File.Create(currentDirectory + path + guidName + type))
            {

                file.CopyTo(filestream);
                filestream.Flush();

            }

            return guidName + type;


        }
        public static void Delete(string imagePath)
        {
            File.Delete(currentDirectory + path + imagePath);
        }
        public static string Update(IFormFile file, string imagePath)
        {

            Delete(imagePath);           
            return Add(file);
        }
    }
}
