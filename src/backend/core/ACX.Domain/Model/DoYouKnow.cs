using ACX.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Domain.Model
{
    public class DoYouKnow:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Title is required")]
        [StringLength(50,ErrorMessage ="The length of title is between 1 to 10 characters")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(int.MaxValue, ErrorMessage = "The length of description is too large")]
        public string? Description { get; set; }
    }
}
