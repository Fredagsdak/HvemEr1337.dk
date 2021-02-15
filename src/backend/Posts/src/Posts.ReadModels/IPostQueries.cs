using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Posts.ReadModels
{
    public interface IPostQueries
    {
        Task<IEnumerable<Post>> GetAll();

        Task<Post> Get(Guid id);
    }
}
