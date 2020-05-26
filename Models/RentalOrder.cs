using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CarRentalProject.Models
{
    public class RentalOrder
    {
        [Key]
        public string CarType { get; set; }

        public string PickUpDate { get; set; }
        public string ReturnDate { get; set; }
        public int Odometer { get; set; }
        public string FuelLevel { get; set; }
        public string ReturnLocation { get; set; }



    }
}
