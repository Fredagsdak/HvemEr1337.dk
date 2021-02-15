using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Posts.ReadModels;

namespace Posts.Api.Controllers.Posts.Get
{
    [Route(Constants.Routes.Posts)]
    public class GetController : ControllerBase
    {
        private readonly IPostQueries _queries;

        public GetController(IPostQueries queries)
        {
            _queries = queries ?? throw new ArgumentNullException(nameof(queries));
        }

        [HttpGet("", Name = Constants.RouteNames.GetAllPosts)]
        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _queries.GetAll();
        }

        [HttpGet("{id}", Name = Constants.RouteNames.GetPost)]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var post = await _queries.Get(id);
            if (post is null)
            {
                return NotFound();
            }

            return Ok(post);
        }
    }
}