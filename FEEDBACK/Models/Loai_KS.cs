namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Loai_KS
    {
        [Key]
        [StringLength(10)]
        public string maloai_KS { get; set; }

        public string ghichu { get; set; }
    }
}
