namespace QLTV.lib.modelsss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phieumuon")]
    public partial class Phieumuon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Maphieu { get; set; }

        public int? Masach { get; set; }

        public int? MaDG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaymuon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaytra { get; set; }

        public int? Soluong { get; set; }

        public virtual Docgia Docgia { get; set; }

        public virtual Sach Sach { get; set; }
    }
}
