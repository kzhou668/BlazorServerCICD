using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("EventType", Schema = "MSPWIP")]
    [Index("Name", Name = "IX_Unique_EventType", IsUnique = true)]
    public partial class EventType
    {
        public EventType()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        [Column("EventTypeID")]
        public int EventTypeId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("EventType")]
        public virtual ICollection<Event> Events { get; set; }
    }
}
