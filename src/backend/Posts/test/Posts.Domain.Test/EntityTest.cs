using System;
using Xunit;

namespace Posts.Domain.Test
{
    public abstract class EntityTest
    {
        private MockEntity _sut;

        private class MockEntity : Entity
        {
            public MockEntity(Guid id) : base(id)
            {
            }
        }

        public sealed class When_initializing : EntityTest
        {
            private Guid _id = Guid.NewGuid();

            public When_initializing()
            {
                _sut = new MockEntity(_id);
            }

            [Fact]
            public void It_sets_id()
            {
                Assert.Equal(_id, _sut.Id);
            }

            [Fact]
            public void It_throws_when_id_is_empty()
            {
                Assert.Throws<ArgumentException>(() => new MockEntity(Guid.Empty));
            }
        }
    }
}
