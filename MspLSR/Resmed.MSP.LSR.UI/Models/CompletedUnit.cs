using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("CompletedUnit", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), Name = "nc_CompletedUnit_WorkOrderNumber")]
    [Index(nameof(UnitIdentifier), nameof(WorkOrderNumber), Name = "unc_CompletedUnit_UnitIdentifier", IsUnique = true)]
    public partial class CompletedUnit
    {
        [Key]
        [Column("CompletedUnitID")]
        public int CompletedUnitId { get; set; }
        [Required]
        [StringLength(40)]
        public string UnitIdentifier { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
