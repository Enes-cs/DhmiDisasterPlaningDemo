using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Equipment:IEntity
    {
        public int EquipmentId { get; set; }
        public string EquipmentName { get; set; }
        public string Class { get; set; }
    }
}
