using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("BOMPart", Schema = "MSPWIP")]
    [Index("ComponentPartCodeType", "WipworkOrderId", Name = "nc_BOMPart_CCodeType_ComponentPartCodeType_WIPWorkOrderID")]
    [Index("WipworkOrderId", "ComponentPartCodeType", "SupplyType", Name = "nc_BOMPart_CCodeType_SupplyType")]
    [Index("ComponentPartCode", "SupplyType", Name = "nc_BOMPart_ComponentPartCodeType_SupplyType")]
    [Index("WipworkOrderId", "Sequence", "BomcomponentId", Name = "nc_BOMPart_WIPWorkOrderID_SQ")]
    [Index("ComponentPartCode", "ComponentPartRev", Name = "nc_BOMPart_componentPartCode_ComponentPartRev")]
    public partial class Bompart
    {
        public Bompart()
        {
            BompartsAttributes = new HashSet<BompartsAttribute>();
        }

        [Key]
        [Column("BOMComponentID")]
        public int BomcomponentId { get; set; }
        [Column("WIPWorkOrderID")]
        public int? WipworkOrderId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string? ParentComponentPartCode { get; set; }
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCodeType { get; set; } = null!;
        [StringLength(240)]
        [Unicode(false)]
        public string? ComponentPartDesc { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ComponentQty { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string? ComponentPartRev { get; set; }
        [StringLength(3)]
        [Unicode(false)]
        public string? IsCriticalComponent { get; set; }
        public int Sequence { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? SupplyType { get; set; }
        public int? SerialControl { get; set; }
        public bool? IsLotControlled { get; set; }

        [ForeignKey("WipworkOrderId")]
        [InverseProperty("Bomparts")]
        public virtual WorkOrder? WipworkOrder { get; set; }
        [InverseProperty("Bomcomponent")]
        public virtual ICollection<BompartsAttribute> BompartsAttributes { get; set; }
    }
}
