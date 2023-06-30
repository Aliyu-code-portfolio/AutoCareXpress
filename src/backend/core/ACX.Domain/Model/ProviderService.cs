using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class ProviderService : AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Ref_Service_Type))]
        public Guid Ref_Service_Type_ID { get; set; }

        [ForeignKey(nameof(ServiceProvider))]
        public Guid ServiceProviderId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Minimum price must be a non-negative number.")]
        public decimal MinPrice { get; set; }
    }
}
