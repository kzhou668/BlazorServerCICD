using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("TrxPatch", Schema = "MSPWIP")]
    [Index(nameof(TrxKey), nameof(WorkOrderNumber), nameof(SerialNumber), nameof(OperationSequenceNumber), Name = "TrxPatch_Key_WO_SN_OSN")]
    [Index(nameof(WorkOrderNumber), nameof(IsComplete), nameof(SerialNumber), nameof(TrxType), Name = "TrxPatch_WO_IC_SB_TrxType")]
    public partial class TrxPatch
    {
        [Key]
        public int TrxId { get; set; }
        [Required]
        [StringLength(40)]
        public string TrxKey { get; set; }
        [Required]
        [StringLength(30)]
        public string TrxType { get; set; }
        [Required]
        [StringLength(30)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string WorkOrderId { get; set; }
        [StringLength(30)]
        public string SerialNumber { get; set; }
        public int? OperationSequenceNumber { get; set; }
        public bool? IsComplete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
    }
}
