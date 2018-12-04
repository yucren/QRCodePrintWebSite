namespace QRCodePrint.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class U9Context : DbContext
    {
        public U9Context()
            : base("name=U9Context")
        {
        }

        public virtual DbSet<Base_Organization> Base_Organization { get; set; }
        public virtual DbSet<Base_Organization_Trl> Base_Organization_Trl { get; set; }
        public virtual DbSet<Base_UOM> Base_UOM { get; set; }
        public virtual DbSet<Base_UOM_Trl> Base_UOM_Trl { get; set; }
        public virtual DbSet<CBO_InventoryInfo> CBO_InventoryInfo { get; set; }
        public virtual DbSet<CBO_ItemMaster> CBO_ItemMaster { get; set; }
        public virtual DbSet<CBO_Supplier> CBO_Supplier { get; set; }
        public virtual DbSet<CBO_Supplier_Trl> CBO_Supplier_Trl { get; set; }
        public virtual DbSet<CBO_Wh> CBO_Wh { get; set; }
        public virtual DbSet<CBO_Wh_Trl> CBO_Wh_Trl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Base_UOM>()
                .Property(e => e.RatioToBase)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.TurnOverRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.TurnOverDays)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.AvgUsageQtyCalDays)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.AvgUsageQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ReferrenceCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.InventoryMaxLimitQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.InventoryMinLimitQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.FixPeriod)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.SafetyStockRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.SafetyStockQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.WastageRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.OrderCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.InventoryCostRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.EconomyOrderQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ReorderQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ApprDiffQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ApprDiffQtyRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ApprDiffAmt)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.ApprDiffAmtRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_InventoryInfo>()
                .Property(e => e.StandardBox)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.StandardBatchQty)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.Weight)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.ItemBulk)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.StandardCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.RefrenceCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.InternalTransCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.RecentlyCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.PlanCost)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.CustomTaxRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.DrawbackRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.BoundedCountToLerance)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_ItemMaster>()
                .Property(e => e.BoundedCountTaxRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_Supplier>()
                .Property(e => e.Turnover)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_Supplier>()
                .Property(e => e.RegisterCapital)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_Supplier>()
                .Property(e => e.CommissionRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_Supplier>()
                .Property(e => e.InsuranceRate)
                .HasPrecision(24, 9);

            modelBuilder.Entity<CBO_Supplier>()
                .Property(e => e.MaxPrePayRate)
                .HasPrecision(24, 9);
        }
    }
}
