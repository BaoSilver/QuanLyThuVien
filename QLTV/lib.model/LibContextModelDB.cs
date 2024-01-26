using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTV.lib.model
{
    public partial class LibContextModelDB : DbContext
    {
        public LibContextModelDB()
            : base("name=LibContextModelDB")
        {
        }

        public virtual DbSet<Docgia> Docgias { get; set; }
        public virtual DbSet<NhaXB> NhaXBs { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Tacgia> Tacgias { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Theloai> Theloais { get; set; }
        public virtual DbSet<Thuthu> Thuthus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
