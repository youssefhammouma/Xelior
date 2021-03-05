using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xelior.Models
{
    public class ProjectItem
    {
        public long Id { get; set; }
        [Required] public string ProjectName { get; set; }
        public long UserId { get; set; }
        public long? JalonId { get; set; }
        
    }
}