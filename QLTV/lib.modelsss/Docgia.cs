namespace QLTV.lib.modelsss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Docgia")]
    public partial class Docgia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Docgia()
        {
            Phieumuons = new HashSet<Phieumuon>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDG { get; set; }

        [StringLength(50)]
        public string TenDG { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaysinh { get; set; }

        [StringLength(10)]
        public string Gioitinh { get; set; }

        [StringLength(255)]
        public string Diachi { get; set; }

        public int? Sodt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phieumuon> Phieumuons { get; set; }
    }
}
