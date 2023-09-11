using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("BOMLabelPrintRecord", Schema = "MSPWIP")]
    [Index("LabelId", Name = "nc_BOMLabelPrintRecord_LabelID")]
    [Index("WorkOrderNumber", "LabelPartCode", Name = "nc_BOMLabelPrintRecord_WO_LPC")]
    [Index("WorkOrderNumber", "RePrinted", "LabelPartCode", "LabelId", Name = "nc_BOMLabelPrintRecord_WO_RP_LPC_LI")]
    [Index("LabelIdLength", Name = "nc_LengthOfLabelId")]
    public partial class BomlabelPrintRecord
    {
        [Key]
        [Column("BOMLabelPrintRecordID")]
        public int BomlabelPrintRecordId { get; set; }
        [Column("LabelID")]
        [StringLength(30)]
        [Unicode(false)]
        public string? LabelId { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? LabelType { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string LabelPartCode { get; set; } = null!;
        public int Quantity { get; set; }
        public bool RePrinted { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string PrinterName { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string? ReprintReason { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? RePrintInstruction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PrintedOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string PrintedBy { get; set; } = null!;
        public int? LabelIdLength { get; set; }
        [Column("QRCode")]
        [StringLength(10)]
        [Unicode(false)]
        public string? Qrcode { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
