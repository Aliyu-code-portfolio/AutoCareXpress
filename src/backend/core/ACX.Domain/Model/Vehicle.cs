using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class Vehicle : AuditableBaseEntity
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Id))]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "Name Description is required")]
        [StringLength(50, ErrorMessage = "Name Description must be at most 50 characters")]
        public string? Name { get; set; }

     
        public string? Color { get; set; }

        [Required(ErrorMessage = "PlateNumber is required")]
        [StringLength (10, ErrorMessage = "PlateNumber must be at most 10 alphanumeric Characters")]
        public string? PlateNumber { get; set; }

        [Required(ErrorMessage = "Manufacture Name is required")]
        [StringLength(25, ErrorMessage = "Manufacture Name must be at most 25 characters")]
        public string? Manufacture { get; set; }

        [Required(ErrorMessage = "Model Name is required")]
        [StringLength(25, ErrorMessage = "Model Name must be at most 25 characters")]
        public string? Model { get; set; }

        // Nagivational Properties
       
    }
}
