using IMS.web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.web.Data
{
  public class ApplicationDbContext : IdentityDbContext
  {
    /*Type ctor and then 2 times tab  it will create a constructor of the class */

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        dbContextOptions) : base(dbContextOptions)
    {

    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      builder.Entity<ApplicationUser>()
          .Property(e => e.FirstName)
          .IsRequired()
          .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
         .Property(e => e.LastName)
          .IsRequired()
         .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
        .Property(e => e.Address)
         .IsRequired()
        .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
        .Property(e => e.Username)
         .IsRequired()
        .HasMaxLength(15);

      /*  builder.Entity<ApplicationUser>()
          .Property(e => e.PhoneNumber)
          .HasMaxLength(15);*/

      builder.Entity<ApplicationUser>()
        .Property(e => e.StoreId)
        .HasMaxLength(5);

      builder.Entity<ApplicationUser>()
        .ToTable("Roles")
      .Property(p => p.UserRollId)
      .HasColumnName("RoleId");

      builder.Entity<ApplicationUser>()
        .Property(e => e.IsActive)
        .HasDefaultValue(true);

      builder.Entity<ApplicationUser>()
        .Property(e => e.ProfileImage)
        .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
        .Property(e => e.UpdatedBy)
        .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
        .Property(e => e.CreatedBy)
        .HasMaxLength(50);

      builder.Entity<ApplicationUser>()
        .Property(e => e.UpdatedDate)
        .IsRequired()
        .HasDefaultValueSql("GETDATE()");

      builder.Entity<ApplicationUser>()
        .Property(e => e.CreatedDate)
        .IsRequired()
        .HasDefaultValueSql("GETDATE()");
    }
  }
}
