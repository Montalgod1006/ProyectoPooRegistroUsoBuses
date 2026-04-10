using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Entities
{
    [Table("buses")]
    public class BusEntity
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }
        
        [Column("route_number")]
        public int RouteNumber { get; set; }
    
        [Column("bus_model")]
        public string BusModel { get; set; }

        //Conductor
        
        [Column("dni")]
        public string DNI { get; set; }
        
        [Column("first_name")]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        public string LastName { get; set; }
    }
}