using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    public partial class OracleStation
    {
        [StringLength(30)]
        [Unicode(false)]
        public string StationName { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string OrgId { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string OperationProductionLine { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string ReviewProductionLine { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string OperationType { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string OperationDescription { get; set; } = null!;
        [StringLength(30)]
        [Unicode(false)]
        public string OperationLocator { get; set; } = null!;
        [Column("OperationLocatorID")]
        public int OperationLocatorId { get; set; }
        [Column("OperationProductionLineID")]
        public int OperationProductionLineId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string ReviewLocator { get; set; } = null!;
        [Column("ReviewLocatorID")]
        public int ReviewLocatorId { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdateDate { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer1 { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer2 { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? Printer3 { get; set; }
    }
}
