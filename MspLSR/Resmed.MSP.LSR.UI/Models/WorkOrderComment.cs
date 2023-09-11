using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("WorkOrderComment", Schema = "MSPWIP")]
    [Index(nameof(Key), Name = "UQ_WorkOrderComment_Key", IsUnique = true)]
    [Index(nameof(WorkOrderNumber), Name = "nc_WorkOrderComment_WorkOrderNumber")]
    public partial class WorkOrderComment
    {
        [Key]
        [Column("WorkOrderCommentID")]
        public int WorkOrderCommentId { get; set; }
        public Guid Key { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Comment { get; set; }
        [Required]
        [StringLength(150)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedOn { get; set; }
        [StringLength(150)]
        public string UpdatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        [StringLength(150)]
        public string ReviewedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewedOn { get; set; }
        [Required]
        public bool? IsActive { get; set; }
        [StringLength(255)]
        public string Instruction { get; set; }
        [StringLength(2000)]
        public string Reason { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
