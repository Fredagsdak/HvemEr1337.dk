using System;
using System.Linq;
using Posts.Domain.Events;
using Xunit;

namespace Posts.Domain.Test
{
    public abstract class PostTest
    {
        private Post _sut;

        public sealed class When_initializing : PostTest
        {
            private Guid _id = Guid.NewGuid();
            private string _message = "Some message";
            private Guid _userId = Guid.NewGuid();

            public When_initializing()
            {
                _sut = new Post(_id, _message, _userId);
            }

            [Fact]
            public void It_throws_when_message_is_null()
            {
                Assert.Throws<ArgumentException>(() => new Post(_id, null, _userId));
            }

            [Fact]
            public void It_throws_when_user_id_is_empty()
            {
                Assert.Throws<ArgumentException>(() => new Post(_id, _message, Guid.Empty));
            }

            [Fact]
            public void It_sets_message()
            {
                Assert.Equal(_message, _sut.Message);
            }

            [Fact]
            public void It_sets_user_id()
            {
                Assert.Equal(_userId, _sut.UserId);
            }

            [Fact]
            public void It_adds_post_created_event()
            {
                Assert.NotEmpty(_sut.DomainEvents.OfType<PostCreated>());
            }
        }
    }
}
