using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Dtos
{
    public class CreateBusDto
    {    
        [Required]
        public int RouteNumber { get; set; }
        [Required]
        public string BusModel { get; set; }

        //Conductor
        [Required]
        public string DNI { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}