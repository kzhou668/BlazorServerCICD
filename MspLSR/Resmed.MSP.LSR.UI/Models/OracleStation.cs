using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Keyless]
    public partial class OracleStation
    {
        [Required]
        [StringLength(30)]
        public string StationName { get; set; }
        [Required]
        [StringLength(3)]
        public string OrgId { get; set; }
        [Required]
        [StringLength(10)]
        public string OperationProductionLine { get; set; }
        [Required]
        [StringLength(10)]
        public string ReviewProductionLine { get; set; }
        [Required]
        [StringLength(30)]
        public string OperationType { get; set; }
        [Required]
        [StringLength(240)]
        public string OperationDescription { get; set; }
        [Required]
        [StringLength(30)]
        public string OperationLocator { get; set; }
        [Column("OperationLocatorID")]
        public int OperationLocatorId { get; set; }
        [Column("OperationProductionLineID")]
        public int OperationProductionLineId { get; set; }
        [Required]
        [StringLength(30)]
        public string ReviewLocator { get; set; }
        [Column("ReviewLocatorID")]
        public int ReviewLocatorId { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdateDate { get; set; }
        [StringLength(30)]
        public string Printer1 { get; set; }
        [StringLength(30)]
        public string Printer2 { get; set; }
        [StringLength(30)]
        public string Printer3 { get; set; }
    }
}
