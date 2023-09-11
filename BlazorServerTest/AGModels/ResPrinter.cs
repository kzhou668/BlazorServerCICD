using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ResPrinter", Schema = "MSPWIP")]
    public partial class ResPrinter
    {
        [Key]
        public int ResPrinterId { get; set; }
        public int ResLabelSpecId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Printer { get; set; } = null!;
        [Required]
        public bool? IsActive { get; set; }

        [ForeignKey("ResLabelSpecId")]
        [InverseProperty("ResPrinters")]
        public virtual ResLabelSpec ResLabelSpec { get; set; } = null!;
    }
}
