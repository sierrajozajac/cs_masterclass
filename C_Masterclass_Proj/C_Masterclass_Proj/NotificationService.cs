using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("Notifying the user that the file {0} has been downloaded.", e.File.Title);
        }
    }
}
