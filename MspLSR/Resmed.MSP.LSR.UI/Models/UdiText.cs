using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("UdiText", Schema = "MSPWIP")]
    public partial class UdiText
    {
        [Key]
        [Column("UdiTextID")]
        public int UdiTextId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [StringLength(30)]
        public string SerialNumber { get; set; }
        [Column("UdiText")]
        [StringLength(100)]
        public string UdiText1 { get; set; }
    }
}
