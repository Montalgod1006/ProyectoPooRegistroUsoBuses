using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Dtos.Routes
{
    public class CreateRouteDto
    {
        [Required]
        public DateOnly Date { get; set; }
        
        [Required]
        public TimeOnly Time { get; set; }

        [Required]
        public int TotalPassengers { get; set; }
    }
}