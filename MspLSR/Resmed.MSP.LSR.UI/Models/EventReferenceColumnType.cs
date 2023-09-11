using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("EventReferenceColumnType", Schema = "MSPWIP")]
    [Index(nameof(Name), Name = "IX_Unique_ERCT", IsUnique = true)]
    public partial class EventReferenceColumnType
    {
        public EventReferenceColumnType()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        [Column("EventReferenceColumnTypeID")]
        public int EventReferenceColumnTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Event.EventReferenceColumnType))]
        public virtual ICollection<Event> Events { get; set; }
    }
}
