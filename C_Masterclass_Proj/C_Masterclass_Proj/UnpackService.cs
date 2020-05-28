using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Unpacking the file: {0}...", e.File.Title);
        }
    }
}
