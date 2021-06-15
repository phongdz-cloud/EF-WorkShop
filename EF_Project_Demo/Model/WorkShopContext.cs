using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Project_Demo.Model
{
    public class WorkShopContext :DbContext
    {

        private const string connectonString = @"
        Data Source=(local);
        Initial Catalog=WorkShopDb;
        Integrated Security=True";
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SalesDetail> SalesDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectonString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Fluent API cho Account
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("TAIKHOAN").HasKey(a => a.UserName);
                entity.Property(a => a.Password)
                    .HasMaxLength(150);
            });

            //Fluent API cho category
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("DANHMUC").HasKey(c => c.CategoryId);
                entity.Property(c =>  c.CategoryName)
                        .HasMaxLength(150);
                entity.Property(c => c.Description)
                       .HasMaxLength(150);

            });
            //Fluent API cho product
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("SANPHAM");
                entity.HasKey(p => p.ProductID); // pk
                entity.Property(p => p.ProductName)
                      .IsRequired()
                      .HasMaxLength(150);
                entity.Property(p => p.Price)
                      .IsRequired()
                      .HasColumnType("money");
                entity.Property(p => p.Amount).
                       HasColumnType("decimal")
                     .IsRequired();
                entity.Property(p => p.Image);
                entity.HasOne(p => p.Category) //
                      .WithMany(p => p.Products)
                      .HasForeignKey(p => p.CategoryID)
                      .OnDelete(DeleteBehavior.SetNull);
            });
            //Fluent API cho hóa đơn
            modelBuilder.Entity<Sale>(entity =>
            {
                entity.ToTable("HOADON")
                        .HasKey(s => s.SaleId);
                entity.Property(s => s.InvoiceDate);
                entity.Property(s => s.Total);
                entity.HasOne(s => s.Employee)
                      .WithMany(e => e.Sales)
                      .HasForeignKey(s => s.EmployeeId)
                      .HasConstraintName("FK_Employee")
                      .OnDelete(DeleteBehavior.SetNull);
            });
            //Flient API cho nhân viên
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("NHANVIEN")
                        .HasKey(e => e.EmployeeId);
                entity.Property(e =>  e.EmployeeName )
                        .IsRequired()
                        .HasMaxLength(100);
                entity.Property(e =>  e.Address )
                        .IsRequired()
                        .HasMaxLength(100);
                entity.Property(e =>  e.Phone )
                        .IsRequired()
                        .HasMaxLength(100);
                entity.Property(e => e.Salary)
                        .IsRequired()
                        .HasColumnName("money");
                entity.Property(e => e.Image);
            });
            // fluent API cho SalesDetail
            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.ToTable("CHITIETHOADON")
                        .HasKey(s => new {s.ProductID,s.SaleId});
                entity.Property(s => s.Amount)
                        .HasColumnType("money");
                entity.HasOne(p => p.Product)
                        .WithMany(p => p.SalesDetails)
                        .HasForeignKey(p => p.ProductID)
                        .HasConstraintName("FK_ProductID")
                         .OnDelete(DeleteBehavior.Cascade);
                        
                entity.HasOne(s => s.Sale)
                        .WithMany(s => s.SalesDetails)
                        .HasForeignKey(s => s.SaleId)
                        .HasConstraintName("FK_SaleID")
                        .OnDelete(DeleteBehavior.Cascade);
            });
        }

    }
}
