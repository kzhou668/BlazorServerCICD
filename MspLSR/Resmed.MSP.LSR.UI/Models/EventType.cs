using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("EventType", Schema = "MSPWIP")]
    [Index(nameof(Name), Name = "IX_Unique_EventType", IsUnique = true)]
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        [Column("EventTypeID")]
        public int EventTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty(nameof(Event.EventType))]
        public virtual ICollection<Event> Events { get; set; }
    }
}
