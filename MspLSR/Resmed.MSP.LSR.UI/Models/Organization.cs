using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("Organization", Schema = "MSPWIP")]
    public partial class Organization
    {
        [Key]
        [Column("OrganizationID")]
        [StringLength(20)]
        public string OrganizationId { get; set; }
        [StringLength(3)]
        public string OrganizationCode { get; set; }
        [StringLength(100)]
        public string OrganizationName { get; set; }
        public bool? IsActive { get; set; }
    }
}
