namespace FEEDBACK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nguoidung")]
    public partial class Nguoidung
    {
        public long ID { get; set; }

        public string ten_dn { get; set; }

        [StringLength(50)]
        public string matkhau { get; set; }
    }
}
