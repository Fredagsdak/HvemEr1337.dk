using System;

namespace Posts.Domain.Builders
{
    public class PostBuilder
    {
        private Guid _id = Guid.NewGuid();
        private string _message = "Some message";
        private Guid _userId = Guid.NewGuid();

        public PostBuilder WithId(Guid id)
        {
            _id = id;
            return this;
        }

        public PostBuilder WithMessage(string message)
        {
            _message = message;
            return this;
        }

        public PostBuilder WithUserId(Guid userId)
        {
            _userId = userId;
            return this;
        }

        public Post Build()
        {
            return new Post(_id, _message, _userId);
        }
    }
}
