using BasicStructure.Data.Models.Cars;
using BasicStructure.Data.Models.Files;
using DataLayer.Entities.Orders;

namespace BasicStructure.Data.Models.Orders
{
    public class Accident
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ClosedAt { get; set; }
        public Order? Order { get; set; }
        public Car Car { get; set; }
        public List<AccidentImage>? PhotoDocumantation { get; set; }
        public List<PDF>? Documantation { get; set; }
    }
}
