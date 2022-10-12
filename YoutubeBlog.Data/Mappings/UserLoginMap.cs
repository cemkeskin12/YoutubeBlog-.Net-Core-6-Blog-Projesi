using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserLoginMap : IEntityTypeConfiguration<AppUserLogin>
    {
        public void Configure(EntityTypeBuilder<AppUserLogin> builder)
        {
            builder.HasKey(l => new { l.LoginProvider, l.ProviderKey });

            // Limit the size of the composite key columns due to common DB restrictions
            builder.Property(l => l.LoginProvider).HasMaxLength(128);
            builder.Property(l => l.ProviderKey).HasMaxLength(128);

            // Maps to the AspNetUserLogins table
            builder.ToTable("AspNetUserLogins");
        }
    }
}
