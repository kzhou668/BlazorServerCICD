using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Keyless]
    public partial class OracleOnHandQuantity
    {
        [Column("InventoryItemID")]
        public int InventoryItemId { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [Column("OrgID")]
        [StringLength(3)]
        public string OrgId { get; set; }
        public int Quantity { get; set; }
        [Required]
        [StringLength(10)]
        public string SubInventoryLocation { get; set; }
        [Column("LocatorID")]
        public int LocatorId { get; set; }
        [Required]
        [StringLength(30)]
        public string LocatorName { get; set; }
        [Required]
        [StringLength(80)]
        public string ControlNumber { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }
    }
}
