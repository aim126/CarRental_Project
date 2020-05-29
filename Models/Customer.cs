using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public int Zipcode { get; set; }

        public string EmailAddress { get; set; }
        public string CarType { get; set; } // is it Economic, Standard,Compact,Van, or a truck ?
        public string CarLocation { get; set; }
        public string CarPickupDate { get; set; }
        public string CarReturnDate { get; set; }
        public string SearchByReturnLocation{ get; set; }
        public double SearchBYPriceRange { get; set; }
        public int SearchByCarUsage { get; set; } //is it for Work , buisiness , Pleasure or a combination?
        public int SearchByGasMilage { get; set; }
        public int SearchByDistanceMileageDesired { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

    }


}
