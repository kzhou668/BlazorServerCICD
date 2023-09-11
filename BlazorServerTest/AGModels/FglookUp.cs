using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("FGLookUp", Schema = "MSPWIP")]
    public partial class FglookUp
    {
        [Key]
        [Column("LookUpID")]
        public int LookUpId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ProductCode { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ProductName { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string PcbaSubAssy { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string FgSoftware { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string Configuration { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string Boot { get; set; } = null!;
        [StringLength(5)]
        [Unicode(false)]
        public string NightProfileCard { get; set; } = null!;
        [StringLength(5)]
        [Unicode(false)]
        public string NightProfileWireless { get; set; } = null!;
        [Column("MID")]
        [StringLength(5)]
        [Unicode(false)]
        public string Mid { get; set; } = null!;
        [Column("VID")]
        [StringLength(5)]
        [Unicode(false)]
        public string Vid { get; set; } = null!;
        [Column("RegionID")]
        [StringLength(5)]
        [Unicode(false)]
        public string RegionId { get; set; } = null!;
        [Required]
        public bool? IsActive { get; set; }
    }
}
