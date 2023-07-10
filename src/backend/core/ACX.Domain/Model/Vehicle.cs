using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class Vehicle : AuditableBaseEntity
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public string? UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name must be at most 50 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Color is required")]
        [StringLength(20, ErrorMessage = "Color must be at most 20 characters")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "PlateNumber is required")]
        [StringLength (10, ErrorMessage = "PlateNumber must be at most 10 alphanumeric Characters")]
        public string? PlateNumber { get; set; }

        [Required(ErrorMessage = "Manufacture name is required")]
        [StringLength(25, ErrorMessage = "Manufacture name must be at most 25 characters")]
        public string? Manufacture { get; set; }

        [Required(ErrorMessage = "Model name is required")]
        [StringLength(25, ErrorMessage = "Model name must be at most 25 characters")]
        public string? Model { get; set; }

        // Nagivational Properties
       public virtual User? User { get; set; }

    }
}
