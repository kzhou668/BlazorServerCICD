using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("BOMPartsAttribute", Schema = "MSPWIP")]
    [Index("BomcomponentId", Name = "nc_BOMPartsAttribute_BOMComponentID")]
    public partial class BompartsAttribute
    {
        [Key]
        [Column("BOMPartsAttributeID")]
        public int BompartsAttributeId { get; set; }
        [Column("BOMComponentID")]
        public int BomcomponentId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Name { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? Value { get; set; }

        [ForeignKey("BomcomponentId")]
        [InverseProperty("BompartsAttributes")]
        public virtual Bompart Bomcomponent { get; set; } = null!;
    }
}
