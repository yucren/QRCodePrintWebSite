namespace QRCodePrint.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CBO_Wh_Trl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SysMLFlag { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(4000)]
        public string DescFlexField_CombineName { get; set; }
    }
}
