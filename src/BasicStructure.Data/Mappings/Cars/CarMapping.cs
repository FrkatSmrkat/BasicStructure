using BasicStructure.Data.Models.Cars;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructure.Data.Mappings.Cars
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .ToTable("cars")
                .HasKey(x => x.Id);

            builder
                .HasIndex(x => x.Id);

            //etc.
        }
    }
}
