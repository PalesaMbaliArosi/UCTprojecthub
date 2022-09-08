using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCTprojecthub.Areas.Identity.Data;
using UCTprojecthub.Models;

namespace UCTprojecthub.Data;

public class UCTprojecthubContext : IdentityDbContext<UCTprojecthubUser, IdentityRole, string>
{
    public UCTprojecthubContext(DbContextOptions<UCTprojecthubContext> options)
        : base(options)
    {
    }

    public DbSet<Theme> Themes { get; set;  }
    public DbSet<Topic> Topics { get; set; }
    public DbSet<Allocation> Allocations { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ProjectHUBUserEntityConfiguration());
        builder.Entity<UCTprojecthubUser>().HasIndex(b => b.StudentNumber).IsUnique();


        builder.Entity<Theme>()
            .HasMany(p => p.Topics)
            .WithOne(p => p.Theme);

        builder.Entity<Theme>().HasData

            (
                new Theme() {Id = Guid.NewGuid(), Title ="eCommerce", Description ="Information relating to real-world application eCommerce in Cape Town", DateCreated = DateTime.Now },
                new Theme() { Id = Guid.NewGuid(), Title = "Blockchain", Description = "A study involving improvements to blockchain technology", DateCreated = DateTime.Now },
                new Theme() { Id = Guid.NewGuid(), Title = "Security", Description = "Developments in security and the improvements to be expected in the future", DateCreated = DateTime.Now },
                new Theme() { Id = Guid.NewGuid(), Title = "Encryption", Description = "An analysis of current encryption protocols implemented within South Africa", DateCreated = DateTime.Now }
            );



    }
}

public class ProjectHUBUserEntityConfiguration : IEntityTypeConfiguration<UCTprojecthubUser>
{
    public void Configure(EntityTypeBuilder<UCTprojecthubUser> builder)
    {
        builder.Property(u => u.FirstName).HasMaxLength(255);
        builder.Property(u => u.LastName).HasMaxLength(255);
        builder.Property(u => u.StudentNumber).HasMaxLength(9);
        builder.Property(u => u.DateCreated).HasDefaultValue(DateTime.Now);


    }
}

