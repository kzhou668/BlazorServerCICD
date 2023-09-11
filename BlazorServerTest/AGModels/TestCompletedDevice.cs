using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("TestCompletedDevice", Schema = "MSPWIP")]
    [Index("WorkOrderNumber", Name = "nc_TestCompletedDevice_WorkOrderNumber")]
    [Index("UnitIdentifier", "WorkOrderNumber", Name = "unc_TestCompleted_UnitIdentifier", IsUnique = true)]
    public partial class TestCompletedDevice
    {
        [Key]
        [Column("CompletedDeviceID")]
        public int CompletedDeviceId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string UnitIdentifier { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdatedDate { get; set; }
        public bool IsActive { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
