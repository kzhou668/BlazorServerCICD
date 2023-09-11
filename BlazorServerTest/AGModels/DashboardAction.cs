using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("DashboardAction", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", "ActionType", "CreatedOn", Name = "UQ_codes", IsUnique = true)]
    [Index("WorkOrderNumber", Name = "nc_FK_DashboardAction_ToWorkOrder")]
    public partial class DashboardAction
    {
        [Key]
        public int DashboardActionId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string ActionType { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
