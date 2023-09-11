using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    public partial class OracleOnHandQuantity
    {
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [Column("OrgID")]
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        public int Quantity { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string SubInventoryLocation { get; set; } = null!;
        [Column("LocatorID")]
        public int LocatorId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string LocatorName { get; set; } = null!;
        [StringLength(80)]
        [Unicode(false)]
        public string ControlNumber { get; set; } = null!;
        [Column("StatusID")]
        public int StatusId { get; set; }
    }
}
