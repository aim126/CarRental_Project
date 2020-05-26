using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalProject.Models
{
    public class Reservation
    {
        [Key]

        public string CarType { get; set; }
        public string CarPickupDate { get; set; }
        public string CarRequierdDays { get; set; }
        public string CarPIckupLocation { get; set; }
        public string CarReturnLocation { get; set; }
    }
}
