namespace QRCodePrint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBO_ItemMaster
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

        public long? BulkUom { get; set; }

        public decimal? StandardBatchQty { get; set; }

        [StringLength(500)]
        public string Code2 { get; set; }

        public bool IsGradeControl { get; set; }

        [StringLength(50)]
        public string CatalogNO { get; set; }

        public int? ItemForm { get; set; }

        public long? Status { get; set; }

        public DateTime? StatusLastModify { get; set; }

        public bool IsInventoryEnable { get; set; }

        public bool IsPurchaseEnable { get; set; }

        public bool IsSalesEnable { get; set; }

        public bool IsBuildEnable { get; set; }

        public bool IsOutsideOperationEnable { get; set; }

        public bool IsMRPEnable { get; set; }

        public bool IsBOMEnable { get; set; }

        public decimal? Weight { get; set; }

        public decimal? ItemBulk { get; set; }

        public long? WeightUom { get; set; }

        public bool IsDualUOM { get; set; }

        public bool IsMultyUOM { get; set; }

        public bool IsDualQuantity { get; set; }

        public int ConverRatioRule { get; set; }

        public bool IsVarRatio { get; set; }

        public long InventoryUOM { get; set; }

        public long PurchaseUOM { get; set; }

        public long SalesUOM { get; set; }

        public long ManufactureUOM { get; set; }

        public long MaterialOutUOM { get; set; }

        public long PriceUOM { get; set; }

        public decimal? StandardCost { get; set; }

        public decimal? RefrenceCost { get; set; }

        public decimal? InternalTransCost { get; set; }

        public decimal? RecentlyCost { get; set; }

        public long? CostCurrency { get; set; }

        public bool? IsIncludedStockAsset { get; set; }

        public bool? IsIncludedCostCa { get; set; }

        public decimal? PlanCost { get; set; }

        public int? StandardGrade { get; set; }

        public int? StartGrade { get; set; }

        public int? EndGrade { get; set; }

        public bool IsPotencyControl { get; set; }

        public int? StandardPotency { get; set; }

        public int? StartPotency { get; set; }

        public int? EndPotency { get; set; }

        public bool? Effective_IsEffective { get; set; }

        public DateTime? Effective_EffectiveDate { get; set; }

        public DateTime? Effective_DisableDate { get; set; }

        public long Org { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg1 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg2 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg3 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg4 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg5 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg6 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg7 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg8 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg9 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg10 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg11 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg12 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg13 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg14 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg15 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg16 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg17 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg18 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg19 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg20 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg21 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg22 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg23 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg24 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg25 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg26 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg27 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg28 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg29 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg30 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg31 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg32 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg33 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg34 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg35 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg36 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg37 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg38 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg39 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg40 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg41 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg42 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg43 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg44 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg45 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg46 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg47 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg48 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg49 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PubDescSeg50 { get; set; }

        [StringLength(50)]
        public string DescFlexField_ContextValue { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg1 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg2 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg3 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg4 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg5 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg6 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg7 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg8 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg9 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg10 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg11 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg12 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg13 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg14 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg15 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg16 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg17 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg18 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg19 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg20 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg21 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg22 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg23 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg24 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg25 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg26 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg27 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg28 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg29 { get; set; }

        [StringLength(1000)]
        public string DescFlexField_PrivateDescSeg30 { get; set; }

        public long CostUOM { get; set; }

        public byte[] Picture { get; set; }

        public bool IsTrademark { get; set; }

        public decimal? CustomTaxRate { get; set; }

        public decimal? DrawbackRate { get; set; }

        [StringLength(50)]
        public string CustomNumber { get; set; }

        public bool IsNeedLicence { get; set; }

        public bool? NeedInspect { get; set; }

        public bool IsBounded { get; set; }

        public int? BoundedCategory { get; set; }

        [StringLength(50)]
        public string BoundedTaxNO { get; set; }

        public decimal? BoundedCountToLerance { get; set; }

        public decimal? BoundedCountTaxRate { get; set; }

        [StringLength(500)]
        public string Code1 { get; set; }

        [StringLength(50)]
        public string SearchCode { get; set; }

        public bool IsVersionQtyControl { get; set; }

        [StringLength(50)]
        public string Version { get; set; }

        public bool? IsVMIEnable { get; set; }

        public int ItemFormAttribute { get; set; }

        public long KeyFlexFieldStru { get; set; }

        [Required]
        [StringLength(255)]
        public string Code { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Segment1 { get; set; }

        [StringLength(255)]
        public string Segment2 { get; set; }

        [StringLength(255)]
        public string Segment3 { get; set; }

        [StringLength(255)]
        public string Segment4 { get; set; }

        [StringLength(255)]
        public string Segment5 { get; set; }

        [StringLength(255)]
        public string Segment6 { get; set; }

        [StringLength(255)]
        public string Segment7 { get; set; }

        [StringLength(255)]
        public string Segment8 { get; set; }

        [StringLength(255)]
        public string Segment9 { get; set; }

        [StringLength(255)]
        public string Segment10 { get; set; }

        [StringLength(255)]
        public string Segment11 { get; set; }

        [StringLength(255)]
        public string Segment12 { get; set; }

        [StringLength(255)]
        public string Segment13 { get; set; }

        [StringLength(255)]
        public string Segment14 { get; set; }

        [StringLength(255)]
        public string Segment15 { get; set; }

        [StringLength(255)]
        public string Segment16 { get; set; }

        [StringLength(255)]
        public string Segment17 { get; set; }

        [StringLength(255)]
        public string Segment18 { get; set; }

        [StringLength(255)]
        public string Segment19 { get; set; }

        [StringLength(255)]
        public string Segment20 { get; set; }

        public bool? IsMISC { get; set; }

        public long NameKeyFlexFieldStru { get; set; }

        [StringLength(255)]
        public string NameSegment1 { get; set; }

        [StringLength(255)]
        public string NameSegment2 { get; set; }

        [StringLength(255)]
        public string NameSegment3 { get; set; }

        [StringLength(255)]
        public string NameSegment4 { get; set; }

        [StringLength(255)]
        public string NameSegment5 { get; set; }

        [StringLength(255)]
        public string NameSegment6 { get; set; }

        [StringLength(255)]
        public string NameSegment7 { get; set; }

        [StringLength(255)]
        public string NameSegment8 { get; set; }

        [StringLength(255)]
        public string NameSegment9 { get; set; }

        [StringLength(255)]
        public string NameSegment10 { get; set; }

        [StringLength(255)]
        public string NameSegment11 { get; set; }

        [StringLength(255)]
        public string NameSegment12 { get; set; }

        [StringLength(255)]
        public string NameSegment13 { get; set; }

        [StringLength(255)]
        public string NameSegment14 { get; set; }

        [StringLength(255)]
        public string NameSegment15 { get; set; }

        [StringLength(255)]
        public string NameSegment16 { get; set; }

        [StringLength(255)]
        public string NameSegment17 { get; set; }

        [StringLength(255)]
        public string NameSegment18 { get; set; }

        [StringLength(255)]
        public string NameSegment19 { get; set; }

        [StringLength(255)]
        public string NameSegment20 { get; set; }

        public long? VersionID { get; set; }

        public long MrpInfo { get; set; }

        public long SaleInfo { get; set; }

        public long PurchaseInfo { get; set; }

        public long InspectionInfo { get; set; }

        public long MfgInfo { get; set; }

        public long InventoryInfo { get; set; }

        public long? MasterOrg { get; set; }

        public long? StockCategory { get; set; }

        public long? ProductionCategory { get; set; }

        public long? SaleCategory { get; set; }

        public long? PurchaseCategory { get; set; }

        public long? MRPCategory { get; set; }

        public long? CostCategory { get; set; }

        public long? PriceCategory { get; set; }

        public long? AssetCategory { get; set; }

        public long? CreditCategory { get; set; }

        public int? State { get; set; }

        public long? StateUser { get; set; }

        public DateTime? StateTime { get; set; }

        public long? TradeMark { get; set; }

        public long? FreeItem1 { get; set; }

        public long? FreeItem2 { get; set; }

        public long? FreeItem3 { get; set; }

        public bool? IsSpecialItem { get; set; }

        [StringLength(255)]
        public string Segment30 { get; set; }

        [StringLength(255)]
        public string Segment21 { get; set; }

        [StringLength(255)]
        public string Segment22 { get; set; }

        [StringLength(255)]
        public string Segment23 { get; set; }

        [StringLength(255)]
        public string Segment24 { get; set; }

        [StringLength(255)]
        public string Segment25 { get; set; }

        [StringLength(255)]
        public string Segment26 { get; set; }

        [StringLength(255)]
        public string Segment27 { get; set; }

        [StringLength(255)]
        public string Segment28 { get; set; }

        [StringLength(255)]
        public string Segment29 { get; set; }

        [StringLength(255)]
        public string NameSegment30 { get; set; }

        [StringLength(255)]
        public string NameSegment21 { get; set; }

        [StringLength(255)]
        public string NameSegment22 { get; set; }

        [StringLength(255)]
        public string NameSegment23 { get; set; }

        [StringLength(255)]
        public string NameSegment24 { get; set; }

        [StringLength(255)]
        public string NameSegment25 { get; set; }

        [StringLength(255)]
        public string NameSegment26 { get; set; }

        [StringLength(255)]
        public string NameSegment27 { get; set; }

        [StringLength(255)]
        public string NameSegment28 { get; set; }

        [StringLength(255)]
        public string NameSegment29 { get; set; }

        public bool? IsCanFlowStat { get; set; }

        public int InventoryUOMGroup { get; set; }

        public long InventorySecondUOM { get; set; }

        [StringLength(300)]
        public string SPECS { get; set; }

        public long EntranceInfo { get; set; }

        public bool? IsCostCalByGrade { get; set; }

        public bool? IsCostCalByPotency { get; set; }

        [StringLength(50)]
        public string ItemSource { get; set; }

        public long? MainItemCategory { get; set; }

        public bool? IsSyncQuantity { get; set; }

        public bool IsMFGConfigEnable { get; set; }

        public bool IsSKU { get; set; }

        [StringLength(50)]
        public string PLMID { get; set; }
    }
}
