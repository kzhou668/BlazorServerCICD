using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ResPrinter", Schema = "MSPWIP")]
    public partial class ResPrinter
    {
        [Key]
        public int ResPrinterId { get; set; }
        public int ResLabelSpecId { get; set; }
        [Required]
        [StringLength(30)]
        public string Printer { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        [ForeignKey(nameof(ResLabelSpecId))]
        [InverseProperty("ResPrinters")]
        public virtual ResLabelSpec ResLabelSpec { get; set; }
    }
}
