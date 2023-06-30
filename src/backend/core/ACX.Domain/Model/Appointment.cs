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
        public Guid ProviderServiceId { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(Ref_Service_Type))]
        public Guid Ref_Service_Type_Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCompleted { get; set; }

        public bool Status { get; set; }
    }
}
