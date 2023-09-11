using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("WorkOrderAttachment", Schema = "MSPWIP")]
    [Index(nameof(Key), Name = "UQ_WorkOrderAttachment_Key", IsUnique = true)]
    [Index(nameof(WorkOrderNumber), Name = "nc_WorkOrderAttachment_WorkOrderNumber")]
    public partial class WorkOrderAttachment
    {
        [Key]
        [Column("WorkOrderAttachmentID")]
        public int WorkOrderAttachmentId { get; set; }
        public Guid Key { get; set; }
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        [Required]
        public byte[] File { get; set; }
        [Required]
        [StringLength(100)]
        public string FileName { get; set; }
        [Required]
        [StringLength(150)]
        public string FileDescription { get; set; }
        [Required]
        [StringLength(150)]
        public string UploadedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UploadedOn { get; set; }
        public int? FileSizeInKb { get; set; }

        public virtual WorkOrder WorkOrderNumberNavigation { get; set; }
    }
}
