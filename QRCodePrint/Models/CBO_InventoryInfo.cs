namespace QRCodePrint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBO_InventoryInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        public DateTime? CreatedOn { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public long? SysVersion { get; set; }

        public bool? IsKitMustWholeSet { get; set; }

        public long? Barcode { get; set; }

        public bool? IsLimitWarehouse { get; set; }

        public long? Warehouse { get; set; }

        public bool? IsLimitBin { get; set; }

        public long? Bin { get; set; }

        public bool? IsReservable { get; set; }

        public int? ReserveDays { get; set; }

        public bool? IsNegativeInventory { get; set; }

        public long? WarehouseManager { get; set; }

        public long? ATPRule { get; set; }

        public long? PickingRule { get; set; }

        public int? PurchaseControlMode { get; set; }

        public decimal? TurnOverRate { get; set; }

        public decimal? TurnOverDays { get; set; }

        public decimal? AvgUsageQtyCalDays { get; set; }

        public decimal? AvgUsageQty { get; set; }

        public int? BarcodeMakeMode { get; set; }

        public bool? IsStructBarcode { get; set; }

        public int? BarcodeTrackMode { get; set; }

        public long? BarCodeRule { get; set; }

        public bool? IsShipmentOverdueLot { get; set; }

        public decimal? ReferrenceCost { get; set; }

        public long? ReferrenceCostCurrency { get; set; }

        public long? PutawayRule { get; set; }

        public int? InventoryPlanningMethod { get; set; }

        public decimal? InventoryMaxLimitQty { get; set; }

        public decimal? InventoryMinLimitQty { get; set; }

        public decimal? FixPeriod { get; set; }

        public DateTime? NextSupplyDate { get; set; }

        public int? SafetyStockType { get; set; }

        public int? SafetyStockPeriod { get; set; }

        public decimal? SafetyStockRate { get; set; }

        public decimal? SafetyStockQty { get; set; }

        public decimal? WastageRate { get; set; }

        public decimal? OrderCost { get; set; }

        public decimal? InventoryCostRate { get; set; }

        public int? InventoryPlanTime { get; set; }

        public decimal? EconomyOrderQty { get; set; }

        public long? TimeBucket { get; set; }

        public decimal? ReorderQty { get; set; }

        public int? LotControlMode { get; set; }

        public long? LotParam { get; set; }

        public long? SnParam { get; set; }

        public int? LotValidDate { get; set; }

        public int? InvToPurMode { get; set; }

        public long? ItemMaster { get; set; }

        public bool? IsIncSerialNo { get; set; }

        public bool? IsIncZeroQty { get; set; }

        public int? ApprDiffRule { get; set; }

        public decimal? ApprDiffQty { get; set; }

        public decimal? ApprDiffQtyRate { get; set; }

        public decimal? ApprDiffAmt { get; set; }

        public decimal? ApprDiffAmtRate { get; set; }

        public int? SupplyMethod { get; set; }

        public int? ReserveMode { get; set; }

        public bool? IsCanalBinUnMarkCheck { get; set; }

        public bool? IsRequiredShipperSupply { get; set; }

        public decimal? StandardBox { get; set; }

        public bool? IsBalanceByProject { get; set; }

        public long? DeliveryPriceGroup { get; set; }

        public bool? IsLotOverdueTransOut { get; set; }

        public bool? IsInvCalculateByTradeMark { get; set; }

        public bool? IsInvCalculateBySeiban { get; set; }

        public bool? IsInvCalculateByVersion { get; set; }

        public bool? IsCostCalByLot { get; set; }

        public bool ConvertRatio { get; set; }

        public int? LotOverdueDays { get; set; }

        public int TakeConvertRatioWhen { get; set; }

        public bool InvCostUOMSettleNumberZero { get; set; }

        public long? PackagingScheme { get; set; }
    }
}
