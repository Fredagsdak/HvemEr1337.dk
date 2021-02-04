using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Posts.Infrastructure;
using Posts.Infrastructure.Models;

namespace Posts.Api.Controllers.Posts.Get
{
    [Route("/posts")]
    public class GetController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public GetController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpGet("")]
        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _dbContext.Posts.ToListAsync();
        }
    }
}