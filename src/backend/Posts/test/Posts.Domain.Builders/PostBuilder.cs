using System;

namespace Posts.Domain.Builders
{
    public class PostBuilder
    {
        private Guid _id = Guid.NewGuid();
        private string _message = "Some message";
        private Guid _userId = Guid.NewGuid();
        private DateTimeOffset _timestamp = new DateTimeOffset(new DateTime(2021, 2, 1, 13, 37, 0));

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

        public PostBuilder WithTimestamp(DateTimeOffset timestamp)
        {
            _timestamp = timestamp;
            return this;
        }

        public Post Build()
        {
            return new Post(_id, _message, _userId, _timestamp);
        }
    }
}
