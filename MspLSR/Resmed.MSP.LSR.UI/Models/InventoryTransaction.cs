using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("InventoryTransaction", Schema = "MSPWIP")]
    public partial class InventoryTransaction
    {
        [Key]
        [Column("TransactionID")]
        public long TransactionId { get; set; }
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Key]
        [StringLength(80)]
        public string ControlNumber { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantity { get; set; }
        [Column("LocatorID")]
        public int LocatorId { get; set; }
        [StringLength(80)]
        public string LocatorName { get; set; }
        [StringLength(80)]
        public string CountryOfOrigin { get; set; }
        [Column("StatusID")]
        public int? StatusId { get; set; }
        [StringLength(20)]
        public string SubInventoryLocation { get; set; }
        [StringLength(3)]
        public string ProcessStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [StringLength(100)]
        public string LotStatus { get; set; }
        [StringLength(40)]
        public string WorkOrderNumber { get; set; }
        [StringLength(40)]
        public string ReferenceId { get; set; }
    }
}
