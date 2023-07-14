using ACX.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACX.Persistence.Configuration
{
    public class DoYouKnowConfiguration : IEntityTypeConfiguration<DoYouKnow>
    {
        public void Configure(EntityTypeBuilder<DoYouKnow> builder)
        {

            builder.HasData(
                new DoYouKnow
                {
                    Id = 1,
                    Title = "Regularly check and change the engine oil",
                    Description = "Engine oil is essential for the smooth running of your car's engine. Check the oil level regularly using the dipstick and change it as per the manufacturer's recommendations."
                },
                new DoYouKnow
                {
                    Id = 2,
                    Title = "Keep an eye on tire pressure",
                    Description = "Maintaining proper tire pressure improves fuel efficiency and extends tire life. Check the tire pressure at least once a month and inflate or deflate them as needed according to the recommended levels mentioned in the owner's manual."
                },
                new DoYouKnow
                {
                    Id = 3,
                    Title = "Rotate and balance tires",
                    Description = "Rotating and balancing your car's tires helps ensure even wear and extends their lifespan. Have this done regularly, generally every 5,000 to 7,500 miles (8,000 to 12,000 kilometers) or as advised in the owner's manual."
                },
                new DoYouKnow
                {
                    Id = 4,
                    Title = "Replace air filters",
                    Description = "Air filters prevent dirt and debris from entering the engine, ensuring its optimal performance. Regularly check and replace both the engine air filter and the cabin air filter based on the recommended intervals."
                },
                new DoYouKnow
                {
                    Id = 5,
                    Title = "Check and replace other fluids",
                    Description = "Your car has several fluids, such as coolant, brake fluid, power steering fluid, and transmission fluid, that require periodic checks and replacements. Refer to the owner's manual to understand the recommended intervals for each."
                },
                new DoYouKnow
                {
                    Id = 6,
                    Title = "Inspect and replace worn-out belts and hoses",
                    Description = "Over time, belts and hoses can wear out and become prone to cracks or leaks. Regularly inspect them for any signs of damage or aging, and replace them as needed."
                },
                new DoYouKnow
                {
                    Id = 7,
                    Title = "Maintain a clean car",
                    Description = "Regularly washing and waxing your car helps protect the paint from damage and keeps it looking good. Additionally, clean the interior regularly, including vacuuming the carpets and wiping down surfaces."
                },
                new DoYouKnow
                {
                    Id = 8,
                    Title = "Pay attention to warning lights",
                    Description = "If any warning lights appear on your dashboard, address them promptly. Ignoring these lights can lead to more significant issues. Consult the owner's manual or seek professional help if necessary."
                },
                new DoYouKnow
                {
                    Id = 9,
                    Title = "Schedule regular maintenance services",
                    Description = "Follow the manufacturer's recommended maintenance schedule for your car. This typically includes routine inspections, oil changes, filter replacements, and other preventive maintenance tasks. Sticking to this schedule helps identify potential problems early on."
                },
                new DoYouKnow
                {
                    Id = 10,
                    Title = "Drive carefully and avoid harsh driving habits",
                    Description = "How you drive greatly impacts the longevity of your car. Avoid aggressive driving, rapid acceleration, and sudden braking, as these can put unnecessary strain on the vehicle's components."
                }
            );
        }
    }
}
