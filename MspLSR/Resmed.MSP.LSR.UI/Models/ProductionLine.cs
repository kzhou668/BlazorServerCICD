using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("ProductionLine", Schema = "MSPWIP")]
    [Index(nameof(ProductionLine1), Name = "unc_ProductionLine_ProductionLine", IsUnique = true)]
    public partial class ProductionLine
    {
        public ProductionLine()
        {
            OnHandQuantities = new HashSet<OnHandQuantity>();
            StationOperationProductionLines = new HashSet<Station>();
            StationReviewProductionLines = new HashSet<Station>();
        }

        [Key]
        [Column("ProductionLineID")]
        public int ProductionLineId { get; set; }
        [Required]
        [Column("ProductionLine")]
        [StringLength(10)]
        public string ProductionLine1 { get; set; }

        [InverseProperty(nameof(OnHandQuantity.ProductionLine))]
        public virtual ICollection<OnHandQuantity> OnHandQuantities { get; set; }
        [InverseProperty(nameof(Station.OperationProductionLine))]
        public virtual ICollection<Station> StationOperationProductionLines { get; set; }
        [InverseProperty(nameof(Station.ReviewProductionLine))]
        public virtual ICollection<Station> StationReviewProductionLines { get; set; }
    }
}
