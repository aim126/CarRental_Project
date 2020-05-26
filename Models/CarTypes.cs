using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalProject.Models
{
    public class CarTypes
    {
        [Key]

        public string EconomicCar { get; set; }
        public string StandardCar { get; set; }
        public string CompactCar { get; set; }

        public string Van { get; set; }

        public string Truck { get; set; }





    }
}
