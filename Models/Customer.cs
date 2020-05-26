using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string EmailAddress { get; set; }
        public string CarType { get; set; } // is it Economic, Standard,Compact,Van, or a truck ?
        public string CarLocation { get; set; }
        public string CarPickupDate { get; set; }
        public string CarReturnDate { get; set; }
        public string CarReturnLocation { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }


}
