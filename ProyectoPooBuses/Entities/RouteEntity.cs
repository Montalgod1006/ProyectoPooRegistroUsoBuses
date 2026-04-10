using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Buses.Entities
{
    [Table("routes")]
    public class RouteEntity
    {
         [Key]
        [Column("id")]
        public string Id { get; set; }

        [ForeignKey(nameof(BusEntity))]
        [Column("bus_id")]
        public string BusId { get; set; }

        [Column("date")]
        public DateOnly Date { get; set; }
        
        [Column("time")]
        public TimeOnly Time { get; set; }

        [Column("total_passengers")]
        public int TotalPassengers { get; set; }
    
    }
}