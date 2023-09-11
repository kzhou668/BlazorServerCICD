using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("AreaClearance", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_FK_AreaClearance_ToWorkOrder")]
    public partial class AreaClearance
    {
        [Key]
        [Column("AreaClearanceID")]
        public int AreaClearanceId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [StringLength(150)]
        public string AreaClearedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AreaClearedOn { get; set; }
        [StringLength(150)]
        public string AreaClearanceInstruction { get; set; }
        public bool AreaCleared { get; set; }
        public bool IsPaused { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
