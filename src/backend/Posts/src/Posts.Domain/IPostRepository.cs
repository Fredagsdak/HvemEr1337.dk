using System.Threading.Tasks;

namespace Posts.Domain
{
    public interface IPostRepository
    {
        Task Save(Post post);
    }
}