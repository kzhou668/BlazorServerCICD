using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("InventoryTransaction", Schema = "MSPWIP")]
    public partial class InventoryTransaction
    {
        [Key]
        [Column("TransactionID")]
        public long TransactionId { get; set; }
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [Key]
        [StringLength(80)]
        [Unicode(false)]
        public string ControlNumber { get; set; } = null!;
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Quantity { get; set; }
        [Column("LocatorID")]
        public int LocatorId { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? LocatorName { get; set; }
        [StringLength(80)]
        [Unicode(false)]
        public string? CountryOfOrigin { get; set; }
        [Column("StatusID")]
        public int? StatusId { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? SubInventoryLocation { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string? ProcessStatus { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? LotStatus { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? WorkOrderNumber { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string? ReferenceId { get; set; }
    }
}
