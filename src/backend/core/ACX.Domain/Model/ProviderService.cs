using ACX.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ACX.Domain.Model
{
    public class ProviderService : AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Ref_Service_Type))]
        public int Ref_Service_Type_ID { get; set; }

        [ForeignKey(nameof(ServiceProvider))]
        public Guid ServiceProviderId { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Minimum price must be a non-negative number.")]
        [Column(TypeName ="money")]
        public decimal MinPrice { get; set; }

        //Navigational properties
        public virtual ServiceProvider? ServiceProvider { get; set; }
        public virtual Ref_Service_Type? Ref_Service_Type { get; set;}
    }
}
