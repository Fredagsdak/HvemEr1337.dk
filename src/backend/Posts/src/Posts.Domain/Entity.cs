using System;
using System.Collections.Generic;
using Posts.Domain.Events;

namespace Posts.Domain
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        private List<IEvent> _domainEvents = new List<IEvent>();

        public IEnumerable<IEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected Entity(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException($"'{nameof(id)}' cannot be empty.", nameof(id));
            }

            Id = id;
        }

        protected void AddDomainEvent(IEvent @event)
        {
            _domainEvents.Add(@event);
        }

        protected void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}