namespace Posts.Api
{
    public static class Constants
    {
        public static class Routes
        {
            public const string Posts = "/p";
        }

        public static class RouteNames
        {
            public const string CreatePost = nameof(CreatePost);

            public const string GetAllPosts = nameof(GetAllPosts);

            public const string GetPost = nameof(GetPost);
        }
    }
}