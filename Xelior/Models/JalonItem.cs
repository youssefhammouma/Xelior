using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xelior.Models
{
    public class JalonItem
    {
        public long Id { get; set; }
        [Required] public string Label { get; set; }
        [Required] public DateTime PlannedStartDateTime { get; set; }
        [Required] public long TaskId { get; set; }
        public DateTime RealEndDateTime { get; set; }
        public long ExigenceId { get; set; }
    }
}