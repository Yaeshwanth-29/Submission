/*using Microsoft.EntityFrameworkCore;
using User_and_Account_Management.Models;

namespace User_and_Account_Management
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated();

            var random = new Random();

            // ================================
            // Roles
            // ================================
            if (!context.Roles.Any())
            {
                var roles = new List<Role>
                {
                    new() { RoleName = "User" },
                    new() { RoleName = "Admin" },
                    new() { RoleName = "Sysadmin" }
                };
                context.Roles.AddRange(roles);
                context.SaveChanges();
            }

            // ================================
            // Banks
            // ================================
            if (!context.Banks.Any())
            {
                var banks = new List<Bank>
                {
                    new() { BankName = "Bank of CSharp" },
                    new() { BankName = "DotNet Bank" },
                    new() { BankName = "Entity Bank" },
                    new() { BankName = "CodeBank" },
                    new() { BankName = "StackBank" }
                };
                context.Banks.AddRange(banks);
                context.SaveChanges();
            }

            var bankList = context.Banks.ToList();

            // ================================
            // Branches
            // ================================
            if (!context.Branches.Any())
            {
                var branches = new List<Branch>();
                for (int i = 0; i < 10; i++)
                {
                    var bank = bankList[random.Next(bankList.Count)];
                    branches.Add(new Branch
                    {
                        BranchName = $"Branch {i + 1} of {bank.BankName}",
                        BankID = bank.BankID,
                        Address = $"{random.Next(100, 999)} Random St"
                    });
                }
                context.Branches.AddRange(branches);
                context.SaveChanges();
            }

            var branchList = context.Branches.ToList();

            // ================================
            // Users
            // ================================
            if (!context.Users.Any())
            {
                var users = new List<User>();
                for (int i = 1; i <= 150; i++)
                {
                    users.Add(new User
                    {
                        FullName = $"User {i}",
                        Username = $"user{i}",
                        Email = $"user{i}@example.com",
                        PasswordHash = "hashedpassword", // replace with actual hashed password
                        CreatedDate = DateTime.UtcNow,
                        ModifiedDate = DateTime.UtcNow,
                        IsActive = true
                    });
                }
                context.Users.AddRange(users);
                context.SaveChanges();
            }

            var userList = context.Users.ToList();
            var userRole = context.Roles.First(r => r.RoleName == "User");

            // ================================
            // UserRoles
            // ================================
            if (!context.UserRoles.Any())
            {
                var userRoles = userList.Select(u => new UserRole
                {
                    UserID = u.UserID,
                    RoleID = userRole.RoleID
                }).ToList();

                context.UserRoles.AddRange(userRoles);
                context.SaveChanges();
            }

            // ================================
            // Accounts
            // ================================
            if (!context.Accounts.Any())
            {
                var accounts = new List<Account>();
                foreach (var user in userList)
                {
                    var bank = bankList[random.Next(bankList.Count)];
                    var branch = branchList[random.Next(branchList.Count)];
                    accounts.Add(new Account
                    {
                        UserID = user.UserID,
                        BankID = bank.BankID,
                        BranchID = branch.BranchID,
                        Balance = random.Next(500, 5000)
                    });
                }
                context.Accounts.AddRange(accounts);
                context.SaveChanges();
            }

            var accountList = context.Accounts.ToList();

            // ================================
            // Transactions
            // ================================
            if (!context.Transactions.Any())
            {
                var transactions = new List<Transaction>();
                for (int i = 0; i < 300; i++) // 300 transactions to match 150 users
                {
                    var account = accountList[random.Next(accountList.Count)];
                    var type = random.NextDouble() > 0.5 ? "Deposit" : "Withdraw";
                    var amount = random.Next(50, 1000);

                    // Prevent negative balance
                    if (type == "Withdraw" && account.Balance < amount)
                    {
                        type = "Deposit";
                    }

                    if (type == "Deposit") account.Balance += amount;
                    else account.Balance -= amount;

                    transactions.Add(new Transaction
                    {
                        AccountID = account.AccountID,
                        TransactionType = type,
                        Amount = amount,
                        TransactionDate = DateTime.UtcNow.AddDays(-random.Next(0, 90))
                    });
                }
                context.Transactions.AddRange(transactions);
                context.SaveChanges();
            }
        }
    }
}
*/