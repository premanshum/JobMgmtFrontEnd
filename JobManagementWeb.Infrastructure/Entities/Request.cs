namespace JobManagementWeb.Infrastructure.Entities
{
    public class Request<I> where I : class
    {
        public string Url { get; set; }

        public string Token { get; set; }

        public string UserId { get; set; }

        public I RequestObject { get; set; }
    }
}
