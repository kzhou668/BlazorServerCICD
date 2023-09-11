using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("EmailType", Schema = "MSP")]
    [Index("Type", Name = "unc_EmailType_Type", IsUnique = true)]
    public partial class EmailType
    {
        public EmailType()
        {
            EmailUsers = new HashSet<EmailUser>();
        }

        [Key]
        public int TypeId { get; set; }
        [StringLength(30)]
        [Unicode(false)]
        public string Type { get; set; } = null!;
        [StringLength(100)]
        [Unicode(false)]
        public string Description { get; set; } = null!;

        [InverseProperty("Type")]
        public virtual ICollection<EmailUser> EmailUsers { get; set; }
    }
}
