namespace QRCodePrint.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class QrCodeModel : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QRCodeList>().Property(m => m.ItemMaster).HasColumnType("nvarchar").HasMaxLength(50);

            base.OnModelCreating(modelBuilder);
        }
        //您的上下文已配置为从您的应用程序的配置文件(App.config 或 Web.config)
        //使用“QrCodeModel”连接字符串。默认情况下，此连接字符串针对您的 LocalDb 实例上的
        //“QRCodePrint.Models.QrCodeModel”数据库。
        // 
        //如果您想要针对其他数据库和/或数据库提供程序，请在应用程序配置文件中修改“QrCodeModel”
        //连接字符串。
        public QrCodeModel()
            : base("name=QrCodeModel")
        {

        }

        //为您要在模型中包含的每种实体类型都添加 DbSet。有关配置和使用 Code First  模型
        //的详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=390109。

         public virtual DbSet<QRCodeList> QRCodeLists { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class  QRCodeList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]   
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="此字段必填")]
        [MaxLength(length: 50, ErrorMessage = "最大不能超过50个字符")]
        public string ItemMaster { get; set; }
        [Required(ErrorMessage = "此字段必填")]
        [MaxLength(length: 50, ErrorMessage = "最大不能超过50个字符")]
        
        public String ItemName { get; set; }
        [Required(ErrorMessage = "此字段必填")]
        [MaxLength(length: 50, ErrorMessage = "最大不能超过50个字符")]
        public string SerialNo { get; set; }
        [Required(ErrorMessage = "此字段必填")]
        [MaxLength(length: 10, ErrorMessage = "最大不能超过10个字符")]
        public string SupplierCode { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [ConcurrencyCheck]
        public DateTime PrintDate { get; set; }



    }
}