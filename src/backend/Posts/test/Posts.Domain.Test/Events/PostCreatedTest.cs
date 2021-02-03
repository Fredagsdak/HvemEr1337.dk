using System;
using Posts.Domain.Builders;
using Xunit;

namespace Posts.Domain.Events.Test
{
    public abstract class PostCreatedTest
    {
        private PostCreated _sut;

        public sealed class When_initializing : PostCreatedTest
        {
            private Post _post = new PostBuilder()
                .Build();

            public When_initializing()
            {
                _sut = new PostCreated(_post);   
            }

            [Fact]
            public void It_sets_post()
            {
                Assert.Equal(_post, _sut.Post);
            }
        }
    }
}
