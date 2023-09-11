using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("BOMPart", Schema = "MSPWIP")]
    [Index(nameof(ComponentPartCodeType), nameof(WipworkOrderId), Name = "nc_BOMPart_CCodeType_ComponentPartCodeType_WIPWorkOrderID")]
    [Index(nameof(WipworkOrderId), nameof(ComponentPartCodeType), nameof(SupplyType), Name = "nc_BOMPart_CCodeType_SupplyType")]
    [Index(nameof(ComponentPartCode), nameof(SupplyType), Name = "nc_BOMPart_ComponentPartCodeType_SupplyType")]
    [Index(nameof(WipworkOrderId), nameof(Sequence), nameof(BomcomponentId), Name = "nc_BOMPart_WIPWorkOrderID_SQ")]
    [Index(nameof(ComponentPartCode), nameof(ComponentPartRev), Name = "nc_BOMPart_componentPartCode_ComponentPartRev")]
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
        public string ParentComponentPartCode { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCode { get; set; }
        [Required]
        [StringLength(40)]
        public string ComponentPartCodeType { get; set; }
        [StringLength(240)]
        public string ComponentPartDesc { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ComponentQty { get; set; }
        [StringLength(3)]
        public string ComponentPartRev { get; set; }
        [StringLength(3)]
        public string IsCriticalComponent { get; set; }
        public int Sequence { get; set; }
        [StringLength(50)]
        public string SupplyType { get; set; }
        public int? SerialControl { get; set; }
        public bool? IsLotControlled { get; set; }

        [ForeignKey(nameof(WipworkOrderId))]
        [InverseProperty(nameof(WorkOrder.Bomparts))]
        public virtual WorkOrder WipworkOrder { get; set; }
        [InverseProperty(nameof(BompartsAttribute.Bomcomponent))]
        public virtual ICollection<BompartsAttribute> BompartsAttributes { get; set; }
    }
}
