using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;
using Microsoft.Extensions.Configuration;

namespace User_and_Account_Management
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration? _configuration;

        // Constructor used by Dependency Injection
        public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        // Parameterless constructor for EF design-time tools
        public AppDbContext() { }

        // DbSets for all tables
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
            // Only configure if not already configured
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration?.GetConnectionString("DefaultConnection")
                    ?? Environment.GetEnvironmentVariable("Training")
                    ?? "Server=localhost;Database=Training;Trusted_Connection=True;TrustServerCertificate=True;";

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // 👇 Ensures EF Core looks under the 'Training' schema instead of 'dbo'
            builder.HasDefaultSchema("Training");

            // ✅ Map table names explicitly to prevent mismatches
            builder.Entity<User>().ToTable("User");
            builder.Entity<Role>().ToTable("Role");
            builder.Entity<Permission>().ToTable("Permission");
            builder.Entity<UserRole>().ToTable("UserRole");
            builder.Entity<RolePermission>().ToTable("RolePermission");
            builder.Entity<Bank>().ToTable("Bank");
            builder.Entity<Branch>().ToTable("Branch");
            builder.Entity<Employee>().ToTable("Employee");
            builder.Entity<Currency>().ToTable("Currency");
            builder.Entity<AccountType>().ToTable("AccountType");
            builder.Entity<Account>().ToTable("Account");
            builder.Entity<Transaction>().ToTable("Transaction");

            // ✅ Composite Keys
            builder.Entity<UserRole>().HasKey(ur => new { ur.UserID, ur.RoleID });
            builder.Entity<RolePermission>().HasKey(rp => new { rp.RoleID, rp.PermissionID });

            builder.Entity<Currency>().HasKey(c => c.CurrencyCode);

            // ✅ Unique Constraint
            builder.Entity<User>().HasIndex(u => u.Email).IsUnique();

            // ✅ Relationships
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
        }
    }
}
