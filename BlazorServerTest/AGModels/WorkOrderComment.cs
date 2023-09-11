using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("WorkOrderComment", Schema = "MSPWIP")]
    [Index("Key", Name = "UQ_WorkOrderComment_Key", IsUnique = true)]
    [Index("WorkOrderNumber", Name = "nc_WorkOrderComment_WorkOrderNumber")]
    public partial class WorkOrderComment
    {
        [Key]
        [Column("WorkOrderCommentID")]
        public int WorkOrderCommentId { get; set; }
        public Guid Key { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
        [Column(TypeName = "text")]
        public string Comment { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string CreatedBy { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [StringLength(150)]
        [Unicode(false)]
        public string? UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string Status { get; set; } = null!;
        [StringLength(150)]
        [Unicode(false)]
        public string? ReviewedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedOn { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [StringLength(255)]
        public string? Instruction { get; set; }
        [StringLength(2000)]
        public string? Reason { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; } = null!;
    }
}
