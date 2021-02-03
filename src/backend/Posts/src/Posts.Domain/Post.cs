using System;
using Posts.Domain.Events;

namespace Posts.Domain
{
    public class Post : Entity, IAggregateRoot
    {
        public string Message { get; }

        public Guid UserId { get; }

        public Post(Guid id, string message, Guid userId) : base(id)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException($"'{nameof(message)}' cannot be null or empty.", nameof(message));
            }

            Message = message;

            if (userId == Guid.Empty)
            {
                throw new ArgumentException($"'{nameof(userId)}' cannot be empty.", nameof(userId));
            }

            UserId = userId;

            AddDomainEvent(new PostCreated(this));
        }
    }
}