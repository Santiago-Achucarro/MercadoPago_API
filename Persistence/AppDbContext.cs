using Microsoft.EntityFrameworkCore;
using MercadoPago_API.Model.App.Scaffolded;

namespace MercadoPago_API.Persistence
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // DbSet para entidades sin clave
        public virtual DbSet<IIMercadoPagoHdr> IIMercadoPagoHdrs { get; set; }
        public virtual DbSet<IIMercadoPagoBody> IIMercadoPagoBodies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
     
            modelBuilder.Entity<IIMercadoPagoHdr>(entity =>
            {
                entity.HasKey(e => e.Id); // Definir la clave primaria

                entity.Property(e => e.Id)
                       .ValueGeneratedOnAdd();

                entity.ToTable("II_MercadoPago_Hdr");

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_ID")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantOrder)
                    .HasColumnName("merchant_Order")
                    .HasMaxLength(31)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IIMercadoPagoBody>(entity =>
            {
                entity.HasKey(e => e.Id); // Definir la clave primaria

                entity.Property(e => e.Id)
                       .ValueGeneratedOnAdd();

                entity.ToTable("II_MercadoPago_Body");

                entity.Property(e => e.MerchantOrder)
                    .HasColumnName("merchant_Order")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentId)
                    .HasColumnName("payment_id")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalReference)
                    .HasColumnName("external_reference")
                    .HasMaxLength(31)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionAmount)
                    .HasColumnName("transaction_amount")
                    .HasColumnType("numeric(19,8)");

                entity.Property(e => e.TotalPaidAmount)
                    .HasColumnName("total_paid_amount")
                    .HasColumnType("numeric(19,8)");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("date_created")
                    .HasMaxLength(51);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
