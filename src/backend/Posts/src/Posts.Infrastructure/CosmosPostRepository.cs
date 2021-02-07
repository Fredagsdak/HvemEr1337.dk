using Microsoft.EntityFrameworkCore;
using Posts.Domain;
using Posts.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.Infrastructure
{
    public class CosmosPostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;

        public CosmosPostRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            var posts = await _context.Posts.ToListAsync();
            return posts.Select(p => p.ToDomain());
        }

        public async Task Save(Post post)
        {
            var model = post.FromDomain();
            _context.Add(model);
            await _context.SaveChangesAsync();
        }
    }
}
