using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("PreviewLabel", Schema = "MSPWIP")]
    [Index("Key", Name = "UQ_PreviewLabel_Key", IsUnique = true)]
    [Index("WorkOrderNumber", Name = "nc_FK_PreviewLabel_ToWorkOrder")]
    public partial class PreviewLabel
    {
        [Key]
        [Column("PreviewLabelID")]
        public int PreviewLabelId { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [StringLength(40)]
        [Unicode(false)]
        public string ComponentPartCode { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? ReviewedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? Instruction { get; set; }
        public Guid Key { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string FileName { get; set; } = null!;
        public byte[] File { get; set; } = null!;

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
