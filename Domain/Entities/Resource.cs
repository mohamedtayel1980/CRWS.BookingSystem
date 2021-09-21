using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Resource:BaseEntity
    {
     
        public string Name { get; set; }
        public int Quantity { get; set; }
        public IQueryable<Booking> Bookings { get; set; }
    }
}
