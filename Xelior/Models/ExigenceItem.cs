using System;
using System.ComponentModel.DataAnnotations;

namespace Xelior.Models
{
    public class ExigenceItem
    {
        public long Id { get; set; } 
        [Required] public string Label { get; set; }
        public long JalonId { get; set; }
    }
}