﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class City:IEntity
    {
        public int CityId { get; set; }
        public int AirportId { get; set; }
        public string CityName { get; set; }
    }
}
