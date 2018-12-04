namespace QRCodePrint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBO_Supplier
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

        public long? Category { get; set; }

        public long? Department { get; set; }

        public long? Purchaser { get; set; }

        public int? TradeCategory { get; set; }

        [StringLength(50)]
        public string CorpUnifyCode { get; set; }

        [StringLength(50)]
        public string StateTaxNo { get; set; }

        [StringLength(50)]
        public string DistrictTaxNo { get; set; }

        public int? State { get; set; }

        public long? Territory { get; set; }

        public long? RegisterLocation { get; set; }

        public long? ReceiptRule { get; set; }

        public bool? IsReceiptRuleEditable { get; set; }

        public int? TransitLeadTime { get; set; }

        public long? PaymentTerm { get; set; }

        public int InvoiceVerificationOrder { get; set; }

        public int InvoiceVerificationDetai { get; set; }

        public int DocVerificationOrder { get; set; }

        public int? EvaluateLevel { get; set; }

        public long? CheckCurrency { get; set; }

        public long? TradeCurrency { get; set; }

        public long? TaxSchedule { get; set; }

        public long? DefaultShipTo { get; set; }

        public long? DefaultBillTo { get; set; }

        public long? DefaultClaim { get; set; }

        public long? DefaultContrast { get; set; }

        public long? DefaultRemit { get; set; }

        public long? DefaultRFQ { get; set; }

        public long? OfficialLocation { get; set; }

        public bool? IsAPConfirmTermEditable { get; set; }

        public long? APConfirmTerm { get; set; }

        public DateTime? EstablishDate { get; set; }

        public long? HoldReason { get; set; }

        public long? ReleaseReason { get; set; }

        public DateTime? HoldDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [StringLength(255)]
        public string ShortName { get; set; }

        public long Org { get; set; }

        public bool? IsPaymentTermModify { get; set; }

        public long? ContactObject { get; set; }

        public bool IsPriceListModify { get; set; }

        [StringLength(50)]
        public string SearchCode { get; set; }

        public bool IsMISC { get; set; }

        public int? EmployeeCount { get; set; }

        public long? Language { get; set; }

        public int QualityPledge { get; set; }

        public int? PledgeMode { get; set; }

        public bool IsBGLineNO { get; set; }

        public bool IsAssistance { get; set; }

        public decimal? Turnover { get; set; }

        public DateTime? LastEvaluateDate { get; set; }

        public int? PledgeCount { get; set; }

        public decimal? RegisterCapital { get; set; }

        [StringLength(50)]
        public string Carrier { get; set; }

        public decimal? CommissionRate { get; set; }

        public decimal? InsuranceRate { get; set; }

        public long? Country { get; set; }

        public int? Bargain { get; set; }

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

        [StringLength(50)]
        public string ReleaseUser { get; set; }

        [StringLength(50)]
        public string HoldUser { get; set; }

        public bool? Effective_IsEffective { get; set; }

        public DateTime? Effective_EffectiveDate { get; set; }

        public DateTime? Effective_DisableDate { get; set; }

        public long KeyFlexFieldStru { get; set; }

        [Required]
        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Segment1 { get; set; }

        [StringLength(50)]
        public string Segment2 { get; set; }

        [StringLength(50)]
        public string Segment3 { get; set; }

        [StringLength(50)]
        public string Segment4 { get; set; }

        [StringLength(50)]
        public string Segment5 { get; set; }

        [StringLength(50)]
        public string Segment6 { get; set; }

        [StringLength(50)]
        public string Segment7 { get; set; }

        [StringLength(50)]
        public string Segment8 { get; set; }

        [StringLength(50)]
        public string Segment9 { get; set; }

        [StringLength(50)]
        public string Segment10 { get; set; }

        [StringLength(50)]
        public string Segment11 { get; set; }

        [StringLength(50)]
        public string Segment12 { get; set; }

        [StringLength(50)]
        public string Segment13 { get; set; }

        [StringLength(50)]
        public string Segment14 { get; set; }

        [StringLength(50)]
        public string Segment15 { get; set; }

        [StringLength(50)]
        public string Segment16 { get; set; }

        [StringLength(50)]
        public string Segment17 { get; set; }

        [StringLength(50)]
        public string Segment18 { get; set; }

        [StringLength(50)]
        public string Segment19 { get; set; }

        [StringLength(50)]
        public string Segment20 { get; set; }

        public long? PriceListID { get; set; }

        public long? RegisterCapitalCurrency { get; set; }

        public long? TurnoverCurrency { get; set; }

        public long? StateUser { get; set; }

        public DateTime? StateTime { get; set; }

        public long? MasterOrg { get; set; }

        public bool? IsHoldRelease { get; set; }

        [StringLength(255)]
        public string PriceListCode { get; set; }

        [StringLength(255)]
        public string PriceListName { get; set; }

        public long? DefaultContractType { get; set; }

        [StringLength(50)]
        public string ContractTypeCode { get; set; }

        [StringLength(50)]
        public string ContractTypeName { get; set; }

        public bool? IsUseAppPortal { get; set; }

        public long? AppPortal { get; set; }

        [StringLength(50)]
        public string Segment30 { get; set; }

        [StringLength(50)]
        public string Segment21 { get; set; }

        [StringLength(50)]
        public string Segment22 { get; set; }

        [StringLength(50)]
        public string Segment23 { get; set; }

        [StringLength(50)]
        public string Segment24 { get; set; }

        [StringLength(50)]
        public string Segment25 { get; set; }

        [StringLength(50)]
        public string Segment26 { get; set; }

        [StringLength(50)]
        public string Segment27 { get; set; }

        [StringLength(50)]
        public string Segment28 { get; set; }

        [StringLength(50)]
        public string Segment29 { get; set; }

        public int OurSideSupplyRecRefStd { get; set; }

        public bool IsHaveContract { get; set; }

        [StringLength(50)]
        public string VMIRuleCode { get; set; }

        [StringLength(50)]
        public string VMIRuleName { get; set; }

        public long? VMIRule { get; set; }

        public bool IsPrePay { get; set; }

        public bool IsPrePayRateEditable { get; set; }

        public decimal? MaxPrePayRate { get; set; }

        public bool? IsPrePayPolicyModify { get; set; }

        [StringLength(50)]
        public string PrePayPolicyCode { get; set; }

        [StringLength(50)]
        public string PrePayPolicyName { get; set; }

        public long? PrePayPolicy { get; set; }

        public bool IsTaxPrice { get; set; }
    }
}
