using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AirportManager : IAirportService
    {
        IAirportDal _airportDal;

        public AirportManager(IAirportDal airportDal)
        {
            _airportDal = airportDal;
        }

        public IResult Add(Airport airport)
        {
            _airportDal.Add(airport);
            return new SuccessResult(Messages.AirportAdded);
        }

        public IDataResult<List<Airport>> GetAll()
        {
            return new SuccessDataResult<List<Airport>>(_airportDal.GetAll(), Messages.AirportsListed);
        }
    }
}
