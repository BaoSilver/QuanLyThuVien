namespace QLTV.lib.modelsss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thuthu")]
    public partial class Thuthu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTT { get; set; }

        [StringLength(50)]
        public string Hoten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
