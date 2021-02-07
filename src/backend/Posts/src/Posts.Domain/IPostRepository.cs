using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posts.Domain
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAll();

        Task Save(Post post);
    }
}