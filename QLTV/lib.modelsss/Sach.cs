namespace QLTV.lib.modelsss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sach")]
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            Phieumuons = new HashSet<Phieumuon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masach { get; set; }

        [StringLength(255)]
        public string Tensach { get; set; }

        [StringLength(50)]
        public string MaTG { get; set; }

        [StringLength(50)]
        public string Maloai { get; set; }

        public int? Manhaxb { get; set; }

        public int? Soluong { get; set; }

        public virtual NhaXB NhaXB { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }

        public virtual Theloai Theloai { get; set; }

        public virtual Tacgia Tacgia { get; set; }
    }
}
