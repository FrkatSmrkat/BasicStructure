using BasicStructure.Data.Models.Orders;
using Microsoft.AspNetCore.Identity;

namespace BasicStructure.Data.Models.Users
{
    public class ApplicationUser
    {
        public int Id { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public UserDocument? DriversLicense { get; set; }
        public UserDocument? IdentificationCard { get; set; }
        public List<Order> Orders { get; set; }
        public bool Approved { get; set; }
    }
}
