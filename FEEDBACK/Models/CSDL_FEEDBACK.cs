namespace FEEDBACK.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CSDL_FEEDBACK : DbContext
    {
        public CSDL_FEEDBACK()
            : base("name=CSDL_FEEDBACK")
        {
        }

        public virtual DbSet<Danhmuc_KS> Danhmuc_KS { get; set; }
        public virtual DbSet<Loai_KS> Loai_KS { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
