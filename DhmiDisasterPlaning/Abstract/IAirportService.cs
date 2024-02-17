using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAirportService
    {
        IResult Add(Airport airport);
        IDataResult<List<Airport>> GetAll();
    }
}
