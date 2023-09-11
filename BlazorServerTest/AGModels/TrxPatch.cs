using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("TrxPatch", Schema = "MSPWIP")]
    [Index("TrxKey", "WorkOrderNumber", "SerialNumber", "OperationSequenceNumber", Name = "TrxPatch_Key_WO_SN_OSN")]
    [Index("WorkOrderNumber", "IsComplete", "SerialNumber", "TrxType", Name = "TrxPatch_WO_IC_SB_TrxType")]
    public partial class TrxPatch
    {
        [Key]
        public int TrxId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string TrxKey { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string TrxType { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string WorkOrderId { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string? SerialNumber { get; set; }
        public int? OperationSequenceNumber { get; set; }
        public bool? IsComplete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}
