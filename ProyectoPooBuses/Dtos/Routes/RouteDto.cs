using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Dtos.Routes
{
    public class RouteDto
    {
         public string Id { get; set; }
        public string BusId { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public int TotalPassengers { get; set; }
    }
}