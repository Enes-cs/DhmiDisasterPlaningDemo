using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Airport:IEntity
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string IataCode { get; set; }
        public int AmountOfWorker { get; set; }
    }
}
