namespace Posts.Api.Configuration
{
    public class ApplicationOptions
    {
        public CosmosDb CosmosDb { get; set; }
    }

    public class CosmosDb
    {
        public string AccountEndpoint { get; set; }

        public string AccountKey { get; set; }

        public string DatabaseName { get; set; }
    }
}