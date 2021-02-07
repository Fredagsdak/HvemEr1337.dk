using Posts.Domain;

namespace Posts.Infrastructure.Extensions
{
    public static class DomainExtensions
    {
        public static Domain.Post ToDomain(this Infrastructure.Models.Post post)
        {
            return new Post(post.Id, post.Message, post.UserId, post.Timestamp);
        }

        public static Infrastructure.Models.Post FromDomain(this Domain.Post post)
        {
            return new Infrastructure.Models.Post
            {
                Id = post.Id,
                Message = post.Message,
                UserId = post.UserId,
                Timestamp = post.Timestamp
            };
        }
    }
}
