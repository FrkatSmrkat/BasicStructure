
using DataLayer.Entities.Files;

namespace BasicStructure.Data.Models.Cars
{
    public class CarInsurance
    {
        public int Id { get; set; }
        public List<PDF>? Documents { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
