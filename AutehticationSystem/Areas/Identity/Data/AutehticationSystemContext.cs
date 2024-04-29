using AutehticationSystem.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutehticationSystem.Areas.Identity.Data;

public class AutehticationSystemContext : IdentityDbContext<AutehticationSystemUser, IdentityRole, string>
{
    public AutehticationSystemContext(DbContextOptions<AutehticationSystemContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" });
        builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "2", Name = "User", NormalizedName = "USER" });
        builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = "3", Name = "Employee", NormalizedName = "EMPLOYEE" });

        builder.ApplyConfiguration(new EntityConfiguration());
        builder.ApplyConfiguration(new EntityRoleConfiguration());
    }
}



public class EntityConfiguration : IEntityTypeConfiguration<AutehticationSystemUser>
{
    public void Configure(EntityTypeBuilder<AutehticationSystemUser> builder)
    {
        builder.Property(name => name.Name).HasMaxLength(50);
        builder.Property(image => image.ImagePath);
    }
}

public class EntityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {

    }
}
