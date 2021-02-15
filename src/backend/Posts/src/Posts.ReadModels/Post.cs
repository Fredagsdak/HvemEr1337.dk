using System;

namespace Posts.ReadModels
{
    public class Post
    {
        public string Message { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}