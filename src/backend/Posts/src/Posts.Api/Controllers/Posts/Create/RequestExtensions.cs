using Posts.Application.Commands;

namespace Posts.Api.Controllers.Posts.Create
{
    public static class RequestExtensions
    {
        public static CreatePostCommand ToCommand(this Request request)
        {
            return new CreatePostCommand(request.Message);
        }
    }
}