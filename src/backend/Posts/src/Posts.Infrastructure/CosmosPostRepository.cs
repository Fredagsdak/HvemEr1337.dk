using Posts.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.Infrastructure
{
    public class CosmosPostRepository : IPostRepository
    {
        public async Task<IEnumerable<Post>> GetAll()
        {
            await Task.CompletedTask;
            return Enumerable.Empty<Post>();
        }
    }
}
