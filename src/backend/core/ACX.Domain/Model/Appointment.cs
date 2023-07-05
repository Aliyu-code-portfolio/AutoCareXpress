using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class Appointment : AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ServiceProvider))]
        public Guid ServiceProviderId { get; set; }

        [ForeignKey(nameof(ProviderService))]
        public int ProviderServiceId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(Ref_Service_Type))]
        public int Ref_Service_Type_Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateCompleted { get; set; }
        [StringLength(int.MaxValue)]
        public string? Description { get; set; }
        public bool Status { get; set; } = false;
        [Range(0, 5,ErrorMessage ="Rating must be in the range 0 - 5")]
        public int? RateService { get; set; }

        //Navigational properties
        public virtual User? User { get; set; }
        public virtual ServiceProvider? ServiceProvider { get; set; }
    }
}
