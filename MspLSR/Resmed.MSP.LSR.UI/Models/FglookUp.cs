using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("FGLookUp", Schema = "MSPWIP")]
    public partial class FglookUp
    {
        [Key]
        [Column("LookUpID")]
        public int LookUpId { get; set; }
        [Required]
        [StringLength(30)]
        public string ProductCode { get; set; }
        [Required]
        [StringLength(30)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(30)]
        public string PcbaSubAssy { get; set; }
        [Required]
        [StringLength(30)]
        public string FgSoftware { get; set; }
        [Required]
        [StringLength(30)]
        public string Configuration { get; set; }
        [Required]
        [StringLength(30)]
        public string Boot { get; set; }
        [Required]
        [StringLength(5)]
        public string NightProfileCard { get; set; }
        [Required]
        [StringLength(5)]
        public string NightProfileWireless { get; set; }
        [Required]
        [Column("MID")]
        [StringLength(5)]
        public string Mid { get; set; }
        [Required]
        [Column("VID")]
        [StringLength(5)]
        public string Vid { get; set; }
        [Required]
        [Column("RegionID")]
        [StringLength(5)]
        public string RegionId { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
