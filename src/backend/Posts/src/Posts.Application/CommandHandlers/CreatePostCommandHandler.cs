using System;
using System.Threading.Tasks;
using Posts.Application.Commands;
using Posts.Domain;

namespace Posts.Application.CommandHandlers
{
    public class CreatePostCommandHandler : ICommandHandler<CreatePostCommand>
    {
        private readonly IPostRepository _repository;

        public CreatePostCommandHandler(IPostRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task Handle(CreatePostCommand command)
        {
            var post = new Post(Guid.NewGuid(), command.Message, Guid.NewGuid(), DateTimeOffset.UtcNow);
            await _repository.Save(post);
        }
    }
}
