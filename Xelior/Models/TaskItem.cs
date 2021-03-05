using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xelior.Models
{
    public class TaskItem
    {
        public long Id { get; set; }
        [Required] public string Label { get; set; }
        [Required] public string Description { get; set; }
        [Required] public long UserId { get; set; }
        [Required] public DateTime PlannedStartDateTime { get; set; }
        public DateTime RealStartDateTime { get; set; }
        [Required] public int Cost { get; set; }

    }
}