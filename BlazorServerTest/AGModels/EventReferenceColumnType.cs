using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("EventReferenceColumnType", Schema = "MSPWIP")]
    [Index("Name", Name = "IX_Unique_ERCT", IsUnique = true)]
    public partial class EventReferenceColumnType
    {
        public EventReferenceColumnType()
        {
            Events = new HashSet<Event>();
        }

        [Key]
        [Column("EventReferenceColumnTypeID")]
        public int EventReferenceColumnTypeId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [InverseProperty("EventReferenceColumnType")]
        public virtual ICollection<Event> Events { get; set; }
    }
}
