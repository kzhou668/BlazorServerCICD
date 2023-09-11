using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Resmed.MSP.LSR.UI.Models
{
    [Keyless]
    public partial class ScrappedDeviceView
    {
        [Required]
        [StringLength(240)]
        public string WorkOrderNumber { get; set; }
        public long? Scrapped { get; set; }
    }
}
