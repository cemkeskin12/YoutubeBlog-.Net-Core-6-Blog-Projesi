using Microsoft.AspNetCore.Identity;

namespace YoutubeBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("F71F4B9A-AA60-461D-B398-DE31001BF214");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
