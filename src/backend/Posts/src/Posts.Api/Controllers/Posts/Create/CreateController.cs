using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Posts.Application.CommandHandlers;
using Posts.Application.Commands;
using Posts.Infrastructure;

namespace Posts.Api.Controllers.Posts.Get
{
    [Route("/posts")]
    public class CreateController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly ICommandHandler<CreatePostCommand> _handler;

        public CreateController(ApplicationDbContext dbContext, ICommandHandler<CreatePostCommand> handler)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _handler = handler ?? throw new ArgumentNullException(nameof(handler));
        }

        [HttpPost("")]
        public async Task<IActionResult> Create([FromBody] Request request)
        {
            var command = request.ToCommand();
            await _handler.Handle(command);

            return Ok();
        }
    }
}