using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace C_Masterclass_Proj
{
    public class FileEventArgs :EventArgs
    {
        public File File { get; set; }
    }

    class DownloadHelper
    {
        // Create a delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);
        // Create an event based on that delegate
        public event FileDownloadedEventHandler FileDownloaded;
        // Raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs(){ File = file });
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);
            OnFileDownloaded(file);
        }
    }
}
