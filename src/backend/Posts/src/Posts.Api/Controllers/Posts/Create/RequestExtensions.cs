using System;
using Posts.Application.Commands;

namespace Posts.Api.Controllers.Posts.Create
{
    public static class RequestExtensions
    {
        public static CreatePostCommand ToCommand(this Request request, Guid id)
        {
            return new CreatePostCommand(id, request.Message);
        }
    }
}