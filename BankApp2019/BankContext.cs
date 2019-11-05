using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BankApp2019
{
    class BankContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BankAppDb;Integrated Security=True;Connect Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(e =>
            {
                e.ToTable("Accounts");

                e.HasKey(a => a.AccountNumber);

                e.Property(a => a.AccountNumber)
                    .ValueGeneratedOnAdd();

                e.Property(a => a.AccountName)
                    .HasMaxLength(50)
                    .IsRequired();

                e.Property(a => a.EmailAddress)
                    .HasMaxLength(100)
                    .IsRequired();

                e.Property(a => a.AccountType)
                    .IsRequired();
                
            });

            modelBuilder.Entity<Transaction>(e =>
            {
                e.ToTable("Transactions");

                e.HasKey(t => t.Id);
                e.Property(t => t.Id)
                    .ValueGeneratedOnAdd();

                e.Property(t => t.TransactionDate)
                    .IsRequired();

                e.Property(t => t.Amount)
                    .IsRequired();

                e.Property(t => t.TransactionType)
                    .IsRequired();

                e.HasOne(t => t.Account)
                    .WithMany()
                    .HasForeignKey(t => t.AccountNumber);

            });
        }
    }
}
