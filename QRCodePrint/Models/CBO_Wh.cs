namespace QRCodePrint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBO_Wh
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

        public long? Department { get; set; }

        public long? Manager { get; set; }

        public long? Location { get; set; }

        [StringLength(50)]
        public string TelephoneNumber { get; set; }

        public bool IsBin { get; set; }

        public bool IsLot { get; set; }

        public bool IsSerial { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

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

        public long? HoldReason { get; set; }

        public long? ReleaseReason { get; set; }

        [StringLength(50)]
        public string HoldUser { get; set; }

        [StringLength(50)]
        public string ReleaseUser { get; set; }

        public DateTime? HoldDate { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public long? Supplier { get; set; }

        public long? Customer { get; set; }

        public bool IsAllowNegative { get; set; }

        public int LocationType { get; set; }

        public int? NormalWhType { get; set; }

        public int? DepositType { get; set; }

        public int? OutboundType { get; set; }

        public bool IsStage { get; set; }

        public bool IsKeepTax { get; set; }

        public bool IsCountReplenish { get; set; }

        public bool? IsCountFrozen { get; set; }

        public long? MasterOrg { get; set; }

        public int? StorageType { get; set; }

        public long? Territory { get; set; }

        public long? Carrier { get; set; }

        public bool? IsSeePlankRelation { get; set; }

        public long? DefaultInStoreBin { get; set; }

        public long? DefaultOutStoreBin { get; set; }

        public bool IsEWH { get; set; }
    }
}
