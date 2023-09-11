using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("DashboardAction", Schema = "MSPWIP")]
    [Index(nameof(WorkOrderNumber), nameof(ActionType), nameof(CreatedOn), Name = "UQ_codes", IsUnique = true)]
    [Index(nameof(WorkOrderNumber), Name = "nc_FK_DashboardAction_ToWorkOrder")]
    public partial class DashboardAction
    {
        [Key]
        public int DashboardActionId { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string ActionType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
