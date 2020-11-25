using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Decision.Entity;

namespace Decision.Context.Mapping
{
    public class AmazonlOrderDetailMap : EntityTypeConfiguration<AmazonlOrderDetail>
    {
        public AmazonlOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.AmazonOrderId)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AmazonOrderItemCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Asin)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Sku)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ItemStatus)
                .HasMaxLength(200);

            this.Property(t => t.Currency)
                .HasMaxLength(200);

            this.Property(t => t.PromotionIds)
                .HasMaxLength(200);

            this.Property(t => t.SysSite)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SysShopsName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Platform)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("AMAZONL_ORDER_DETAIL");
            this.Property(t => t.Id).HasColumnName("ID");
            this.Property(t => t.AmazonOrderId).HasColumnName("AMAZON_ORDER_ID");
            this.Property(t => t.AmazonOrderItemCode).HasColumnName("AMAZON_ORDER_ITEM_CODE");
            this.Property(t => t.Asin).HasColumnName("ASIN");
            this.Property(t => t.Sku).HasColumnName("SKU");
            this.Property(t => t.ItemStatus).HasColumnName("ITEM_STATUS");
            this.Property(t => t.Quantity).HasColumnName("QUANTITY");
            this.Property(t => t.Principal).HasColumnName("PRINCIPAL");
            this.Property(t => t.Tax).HasColumnName("TAX");
            this.Property(t => t.Currency).HasColumnName("CURRENCY");
            this.Property(t => t.Shipping).HasColumnName("SHIPPING");
            this.Property(t => t.ShippingTax).HasColumnName("SHIPPING_TAX");
            this.Property(t => t.Giftwrap).HasColumnName("GIFTWRAP");
            this.Property(t => t.GiftwrapTax).HasColumnName("GIFTWRAP_TAX");
            this.Property(t => t.PromotionIds).HasColumnName("PROMOTION_IDS");
            this.Property(t => t.ItemPromotionDiscount).HasColumnName("ITEM_PROMOTION_DISCOUNT");
            this.Property(t => t.ShipPromotionDiscount).HasColumnName("SHIP_PROMOTION_DISCOUNT");
            this.Property(t => t.SysSite).HasColumnName("SYS_SITE");
            this.Property(t => t.SysShopsName).HasColumnName("SYS_SHOPS_NAME");
            this.Property(t => t.CreateTime).HasColumnName("CREATE_TIME");
            this.Property(t => t.UploadDate).HasColumnName("UPLOAD_DATE");
            this.Property(t => t.Platform).HasColumnName("PLATFORM");

        }
    }
}


