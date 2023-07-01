using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ACX.Domain.Model
{
    public class Ref_Service_Type:AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage="Service Name is required")]
        [StringLength(25, ErrorMessage = "Service Name must be at most 25 characters")]
        public string? ServiceName { get; set; }
        [Required(ErrorMessage = "Service Description is required")]
        [StringLength(100, ErrorMessage = "Service Description must be at most 100 characters")]
        public string? Description { get; set; }

        //Navigational Properties
        public virtual ProviderService? ProviderService { get; set; }
    }
}
