using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;
using System.Transactions;

namespace C_Masterclass_Proj
{
    class VideoPost :Post
    {
        protected bool isPlaying = false;
        protected double currDuration = 0;
        Timer timer;

        private string VideoURL { get; set; }
        private double VideoLength { get; set; }

        public VideoPost()
        {
            this.ID = this.GetNextID();
        }

        public VideoPost(string title, bool isPublic, string sentBy, string url, double length)
        {
            this.ID = this.GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SentByUsername = sentBy;
            this.VideoURL = url;
            this.VideoLength = length;
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }

        private void TimerCallback(Object o)
        {
            if (currDuration < VideoLength)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, this.VideoURL, this.VideoLength, this.SentByUsername);
        }
    }
}
