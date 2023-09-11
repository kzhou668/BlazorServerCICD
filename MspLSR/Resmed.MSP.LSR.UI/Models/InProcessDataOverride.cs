using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("InProcessDataOverride", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), nameof(ComponentPartCode), Name = "UX_InProcessDataOverrideUnique", IsUnique = true)]
    public partial class InProcessDataOverride
    {
        [Key]
        public int InProcessDataOverrideId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(80)]
        public string OverriddenBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime OverriddenOn { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
