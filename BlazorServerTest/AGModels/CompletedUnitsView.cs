using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerTest.AGModels
{
    [Keyless]
    public partial class CompletedUnitsView
    {
        public int? Completed { get; set; }
        [StringLength(240)]
        [Unicode(false)]
        public string WorkOrderNumber { get; set; } = null!;
    }
}
