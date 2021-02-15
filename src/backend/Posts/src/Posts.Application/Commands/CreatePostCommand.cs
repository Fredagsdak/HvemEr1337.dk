using System;

namespace Posts.Application.Commands
{
    public class CreatePostCommand : ICommand
    {
        public Guid Id { get; }

        public string Message { get; }

        public CreatePostCommand(Guid id, string message)
        {
            Id = id;
            Message = message;
        }
    }
}
