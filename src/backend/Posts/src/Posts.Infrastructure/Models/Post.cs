using System;

namespace Posts.Infrastructure.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        public string Message { get; set; }

        public DateTimeOffset Timestamp { get; set; }
    }
}
