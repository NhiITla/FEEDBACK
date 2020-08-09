namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Danhmuc_KS
    {
        [Key]
        [Column(Order = 0)]
        public long ma_KS { get; set; }

        public string ten_coso { get; set; }

        public int? so_phong { get; set; }

        public int? so_giuong { get; set; }

        public string diachi { get; set; }

        public string dienthoai { get; set; }

        public string email { get; set; }

        public string ghichu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maloai_KS { get; set; }
    }
}
