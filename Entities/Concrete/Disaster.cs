using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Disaster:IEntity
    {
        public int DisasterId { get; set; }
        public string DisasterName { get; set; }
        public string DisasterLevel { get; set;}
    }
}
