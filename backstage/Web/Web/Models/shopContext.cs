using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Web.Models
{
    public partial class shopContext : DbContext
    {
        public shopContext()
        {
        }

        public shopContext(DbContextOptions<shopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Orderitem> Orderitems { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=abc123456789;database=shop", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.MId)
                    .HasName("PRIMARY");

                entity.ToTable("account");

                entity.Property(e => e.MId)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("mID")
                    .HasCharSet("utf32")
                    .HasCollation("utf32_general_ci");

                entity.Property(e => e.Account1)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("account")
                    .HasCharSet("utf32")
                    .HasCollation("utf32_general_ci");

                entity.Property(e => e.MAddress)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("mAddress")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MBirth)
                    .HasColumnType("date")
                    .HasColumnName("mBirth");

                entity.Property(e => e.MEmail)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("mEmail")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MName)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("mName")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MPhone)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("mPhone")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.MRole)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("mRole")
                    .HasCharSet("utf32")
                    .HasCollation("utf32_general_ci");

                entity.Property(e => e.MSex)
                    .HasColumnType("varchar(1)")
                    .HasColumnName("mSex")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("password")
                    .HasCharSet("utf32")
                    .HasCollation("utf32_general_ci");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CId)
                    .HasName("PRIMARY");

                entity.ToTable("category");

                entity.Property(e => e.CId)
                    .ValueGeneratedNever()
                    .HasColumnName("cID");

                entity.Property(e => e.CDescription)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("cDescription")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.CName)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("cName")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OId)
                    .HasName("PRIMARY");

                entity.ToTable("order");

                entity.Property(e => e.OId).HasColumnName("oID");

                entity.Property(e => e.MId).HasColumnName("mID");

                entity.Property(e => e.OTime)
                    .HasColumnType("datetime")
                    .HasColumnName("oTime");
            });

            modelBuilder.Entity<Orderitem>(entity =>
            {
                entity.HasKey(e => new { e.OId, e.OiId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("orderitem");

                entity.HasIndex(e => e.PId, " _idx");

                entity.Property(e => e.OId).HasColumnName("oID");

                entity.Property(e => e.OiId).HasColumnName("oiID");

                entity.Property(e => e.OiDiscount).HasColumnName("oiDiscount");

                entity.Property(e => e.OiQuantity).HasColumnName("oiQuantity");

                entity.Property(e => e.OiSpecialoption)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("oiSpecialoption")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PId).HasColumnName("pID");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.PId)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.Property(e => e.PId).HasColumnName("pID");

                entity.Property(e => e.PCategory)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("pCategory")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PContractor)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("pContractor")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PDescription)
                    .HasColumnType("mediumtext")
                    .HasColumnName("pDescription")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PImage)
                    .HasColumnType("mediumblob")
                    .HasColumnName("pImage");

                entity.Property(e => e.PName)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("pName")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PPrice).HasColumnName("pPrice");

                entity.Property(e => e.PRemaining).HasColumnName("pRemaining");

                entity.Property(e => e.PSaledate)
                    .HasColumnType("date")
                    .HasColumnName("pSaledate");

                entity.Property(e => e.PStatus)
                    .HasColumnType("varchar(45)")
                    .HasColumnName("pStatus")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
