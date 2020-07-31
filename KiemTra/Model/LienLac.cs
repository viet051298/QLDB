namespace KiemTra.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LienLac")]
    public partial class LienLac
    {
        [Key]
        [StringLength(50)]
        public string TenGoi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }
    }
}
