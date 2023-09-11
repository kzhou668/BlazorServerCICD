using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("UnitCheck", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_UnitCheck_WorkOrderNumber")]
    public partial class UnitCheck
    {
        [Key]
        public int UnitCheckId { get; set; }
        [Required]
        [StringLength(30)]
        public string UnitIdentifier { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(10)]
        public string UnitCheckType { get; set; }
        [StringLength(150)]
        public string CheckedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CheckedOn { get; set; }
        [StringLength(500)]
        public string Instruction { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
