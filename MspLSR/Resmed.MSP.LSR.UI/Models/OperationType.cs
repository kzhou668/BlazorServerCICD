using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Table("OperationType", Schema = "MSPWIP")]
    [Index(nameof(OperationType1), nameof(OperationDescription), Name = "unc_operationType_OptType_optDesc", IsUnique = true)]
    public partial class OperationType
    {
        public OperationType()
        {
            Stations = new HashSet<Station>();
        }

        [Key]
        [Column("OperationTypeID")]
        public int OperationTypeId { get; set; }
        [Required]
        [Column("OperationType")]
        [StringLength(30)]
        public string OperationType1 { get; set; }
        [Required]
        [StringLength(240)]
        public string OperationDescription { get; set; }

        [InverseProperty(nameof(Station.OperationType))]
        public virtual ICollection<Station> Stations { get; set; }
    }
}
