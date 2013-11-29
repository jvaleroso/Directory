using System.Collections.Generic;
using Directory.Dao;
using Directory.Service;

namespace Directory.Services
{
    public class CityService: ICityService
    {
        private readonly ICityDao _cityDao;

        public CityService(ICityDao cityDao)
        {
            _cityDao = cityDao;
        }

        public void Delete(City city)
        {
            _cityDao.Delete(city);
        }

        public IList<City> List()
        {
            return _cityDao.List();
        }

        public City Get(long id)
        {
            return _cityDao.Get(id);
        }

        public City Save(City city)
        {
            return _cityDao.Save(city);
        }
    }
}
