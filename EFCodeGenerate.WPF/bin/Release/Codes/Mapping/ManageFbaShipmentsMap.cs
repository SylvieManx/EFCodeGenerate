using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Decision.Entity;

namespace Decision.Context.Mapping
{
    public class ManageFbaShipmentsMap : EntityTypeConfiguration<ManageFbaShipments>
    {
        public ManageFbaShipmentsMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Sku)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Fnsku)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Asin)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SysSellerId)
                .HasMaxLength(200);

            this.Property(t => t.SysSite)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SysShopsName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UserName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MANAGE_FBA_SHIPMENTS");
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.Sku).HasColumnName("SKU");
            this.Property(t => t.Fnsku).HasColumnName("FNSKU");
            this.Property(t => t.Asin).HasColumnName("ASIN");
            this.Property(t => t.Shipped).HasColumnName("SHIPPED");
            this.Property(t => t.SysSellerId).HasColumnName("SYS_SELLER_ID");
            this.Property(t => t.SysSite).HasColumnName("SYS_SITE");
            this.Property(t => t.SysShopsName).HasColumnName("SYS_SHOPS_NAME");
            this.Property(t => t.CreateTime).HasColumnName("CREATE_TIME");
            this.Property(t => t.UploadDate).HasColumnName("UPLOAD_DATE");
            this.Property(t => t.UserName).HasColumnName("USER_NAME");

        }
    }
}


