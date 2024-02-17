using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Worker:IEntity
    {
        public int WorkerId { get; set; }
        public int AirportId { get; set; }
        public int RegistrationNumber { get; set; }
        public string Title { get; set; }
        public string RescueTrainingLevel { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
