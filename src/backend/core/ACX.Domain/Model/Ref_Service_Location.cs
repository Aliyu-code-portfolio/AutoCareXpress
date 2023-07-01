using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ACX.Domain.Model
{
    public class Ref_Service_Location:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Service Location is required")]
        [StringLength(25, ErrorMessage = "Service Location must be at most 25 characters")]
        public string? Location { get; set; }

        //Navigational properties
        public virtual ServiceProvider? ServiceProvider { get; set; }
    }
}
