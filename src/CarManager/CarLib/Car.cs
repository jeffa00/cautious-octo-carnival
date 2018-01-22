using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CCA.CarLib 
{
    public class Car : Vehicle
    {
        [Display(Name = "Number of Doors")]
        public int NumberOfDoors { get; set; }
    }
}
