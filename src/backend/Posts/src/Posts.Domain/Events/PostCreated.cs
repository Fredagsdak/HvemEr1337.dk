namespace Posts.Domain.Events
{
    public class PostCreated : IEvent
    {
        public Post Post { get; }

        public PostCreated(Post post)
        {
            Post = post;
        }
    }
}