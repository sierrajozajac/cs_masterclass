using System;
using System.Collections.Generic;
using System.Text;

namespace C_Masterclass_Proj
{
    class Post
    {
        private static int currPostID;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SentByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SentByUsername = "Sierra Jo Sallee";
        }

        public Post(string title, bool isPublic, string sentBy)
        {
            ID = GetNextID();
            Title = title;
            SentByUsername = sentBy;
            IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currPostID;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", ID, Title, SentByUsername);
        }
    }
}
