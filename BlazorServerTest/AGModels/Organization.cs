using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Table("Organization", Schema = "MSPWIP")]
    public partial class Organization
    {
        [Key]
        [Column("OrganizationID")]
        [StringLength(20)]
        [Unicode(false)]
        public string OrganizationId { get; set; } = null!;
        [StringLength(3)]
        [Unicode(false)]
        public string? OrganizationCode { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string? OrganizationName { get; set; }
        public bool? IsActive { get; set; }
    }
}
