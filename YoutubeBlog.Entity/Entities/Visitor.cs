using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Entity.Entities
{
    public class Visitor : IEntityBase
    {
        public Visitor() { }

        public Visitor(string ipAddress,string userAgent)
        {
            IpAddress = ipAddress;
            UserAgent = userAgent;
        }

        public int Id { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }

    }
}
