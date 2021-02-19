using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Posts.Infrastructure;

namespace Posts.ReadModels
{
    public class PostQueries : IPostQueries
    {
        private readonly ApplicationDbContext _dbContext;

        public PostQueries(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _dbContext.Posts.Select(p => new Post
            {
                Id = p.Id,
                Message = p.Message,
                Timestamp = p.Timestamp
            }).ToListAsync();
        }

        public async Task<Post> Get(Guid id)
        {
            var post = await _dbContext.Posts.FirstOrDefaultAsync(p => p.Id == id);
            return post != null ?
                new Post
                {
                    Message = post.Message,
                    Timestamp = post.Timestamp
                } : null;
        }
    }
}
