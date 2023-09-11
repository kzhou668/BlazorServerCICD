using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("BOMLabelPrintRecord", Schema = "MSPWIP")]
    [Index(nameof(LabelId), Name = "nc_BOMLabelPrintRecord_LabelID")]
    [Index(nameof(WorkOrderNumber), nameof(LabelPartCode), Name = "nc_BOMLabelPrintRecord_WO_LPC")]
    [Index(nameof(WorkOrderNumber), nameof(RePrinted), nameof(LabelPartCode), nameof(LabelId), Name = "nc_BOMLabelPrintRecord_WO_RP_LPC_LI")]
    [Index(nameof(LabelIdLength), Name = "nc_LengthOfLabelId")]
    public partial class BomlabelPrintRecord
    {
        [Key]
        [Column("BOMLabelPrintRecordID")]
        public int BomlabelPrintRecordId { get; set; }
        [Column("LabelID")]
        [StringLength(30)]
        public string LabelId { get; set; }
        [StringLength(10)]
        public string LabelType { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string LabelPartCode { get; set; }
        public int Quantity { get; set; }
        public bool RePrinted { get; set; }
        [Required]
        [StringLength(30)]
        public string PrinterName { get; set; }
        [StringLength(100)]
        public string ReprintReason { get; set; }
        [StringLength(150)]
        public string RePrintInstruction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime PrintedOn { get; set; }
        [Required]
        [StringLength(50)]
        public string PrintedBy { get; set; }
        public int? LabelIdLength { get; set; }
        [Column("QRCode")]
        [StringLength(10)]
        public string Qrcode { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
