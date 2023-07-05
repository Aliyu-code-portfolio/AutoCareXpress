using ACX.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Configuration
{
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<Ref_Service_Type>
    {
        public void Configure(EntityTypeBuilder<Ref_Service_Type> builder)
        {
            builder.HasData(
                     new List<Ref_Service_Type>
                        {
                            new Ref_Service_Type { Id = 1, ServiceName = "Roadside Assistance", Description = "Providing immediate assistance for breakdowns, flat tires, jump starts, etc." },
                            new Ref_Service_Type { Id = 2, ServiceName = "Maintenance Services", Description = "Offering routine maintenance services like oil changes, filter replacements, and brake inspections." },
                            new Ref_Service_Type { Id = 3, ServiceName = "Repairs", Description = "Handling repairs for various car components, including engines, brakes, electrical systems, etc." },
                            new Ref_Service_Type { Id = 4, ServiceName = "Bodywork and Paint", Description = "Providing services related to dents, scratches, and painting jobs." },
                            new Ref_Service_Type { Id = 5, ServiceName = "Towing", Description = "Offering towing services for vehicles in need of transportation." }
                        }
                );
        }
    }
}
