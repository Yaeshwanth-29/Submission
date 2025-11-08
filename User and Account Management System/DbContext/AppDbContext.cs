using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;
using Microsoft.Extensions.Configuration;

namespace User_and_Account_Management
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        // Constructor used by DI
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        // Parameterless constructor used by EF design-time tools
        public AppDbContext() { }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Only configure if not already configured (design-time)
            if (!optionsBuilder.IsConfigured)
            {
                // Use environment variable or fallback to default connection
                var connectionString = Environment.GetEnvironmentVariable("Training")
                                       ?? "Server=localhost;Database=Training;Trusted_Connection=True;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>().HasKey(ur => new { ur.UserID, ur.RoleID });
            builder.Entity<RolePermission>().HasKey(rp => new { rp.RoleID, rp.PermissionID });

            builder.Entity<Currency>().HasKey(c => c.CurrencyCode);

            builder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            builder.Entity<UserRole>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRoles)
                .HasForeignKey(ur => ur.UserID);

            builder.Entity<UserRole>()
                .HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleID);

            builder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleID);

            builder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.PermissionID);

            // Add other relationships as needed
        }
    }
}
