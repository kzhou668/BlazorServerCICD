using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("ProductionLine", Schema = "MSPWIP")]
    [Index("ProductionLine1", Name = "unc_ProductionLine_ProductionLine", IsUnique = true)]
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
        [Column("ProductionLine")]
        [StringLength(10)]
        [Unicode(false)]
        public string ProductionLine1 { get; set; } = null!;

        [InverseProperty("ProductionLine")]
        public virtual ICollection<OnHandQuantity> OnHandQuantities { get; set; }
        [InverseProperty("OperationProductionLine")]
        public virtual ICollection<Station> StationOperationProductionLines { get; set; }
        [InverseProperty("ReviewProductionLine")]
        public virtual ICollection<Station> StationReviewProductionLines { get; set; }
    }
}
