using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("BOMPartsAttribute", Schema = "MSPWIP")]
    [Index(nameof(BomcomponentId), Name = "nc_BOMPartsAttribute_BOMComponentID")]
    public partial class BompartsAttribute
    {
        [Key]
        [Column("BOMPartsAttributeID")]
        public int BompartsAttributeId { get; set; }
        [Column("BOMComponentID")]
        public int BomcomponentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Value { get; set; }

        [ForeignKey(nameof(BomcomponentId))]
        [InverseProperty(nameof(Bompart.BompartsAttributes))]
        public virtual Bompart Bomcomponent { get; set; }
    }
}
