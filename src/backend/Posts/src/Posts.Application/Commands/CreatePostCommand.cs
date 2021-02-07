namespace Posts.Application.Commands
{
    public class CreatePostCommand : ICommand
    {
        public string Message { get; }

        public CreatePostCommand(string message)
        {
            Message = message;
        }
    }
}
