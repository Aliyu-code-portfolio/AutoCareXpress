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
    public class ServiceLocationConfiguration : IEntityTypeConfiguration<Ref_Service_Location>
    {
        public void Configure(EntityTypeBuilder<Ref_Service_Location> builder)
        {
            builder.HasData(
                new List<Ref_Service_Location>
                {
                    new Ref_Service_Location { Id = 1, Location = "Agege" },
                    new Ref_Service_Location { Id = 2, Location = "Ajeromi-Ifelodun" },
                    new Ref_Service_Location { Id = 3, Location = "Alimosho" },
                    new Ref_Service_Location { Id = 4, Location = "Amuwo-Odofin" },
                    new Ref_Service_Location { Id = 5, Location = "Apapa" },
                    new Ref_Service_Location { Id = 6, Location = "Badagry" },
                    new Ref_Service_Location { Id = 7, Location = "Epe" },
                    new Ref_Service_Location { Id = 8, Location = "Eti-Osa" },
                    new Ref_Service_Location { Id = 9, Location = "Ibeju/Lekki" },
                    new Ref_Service_Location { Id = 10, Location = "Ifako-Ijaye" },
                    new Ref_Service_Location { Id = 11, Location = "Ikeja" },
                    new Ref_Service_Location { Id = 12, Location = "Ikorodu" },
                    new Ref_Service_Location { Id = 13, Location = "Kosofe" },
                    new Ref_Service_Location { Id = 14, Location = "Lagos Island" },
                    new Ref_Service_Location { Id = 15, Location = "Lagos Mainland" },
                    new Ref_Service_Location { Id = 16, Location = "Mushin" },
                    new Ref_Service_Location { Id = 17, Location = "Ojo" },
                    new Ref_Service_Location { Id = 18, Location = "Oshodi-Isolo" },
                    new Ref_Service_Location { Id = 19, Location = "Shomolu" },
                    new Ref_Service_Location { Id = 20, Location = "Surulere" }
                }
            );
        }
    }
}
