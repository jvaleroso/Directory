using System.Collections.Generic;
using AutoMapper;
using Directory.Dao.NHibernate.Repo;

namespace Directory.Dao.NHibernate.Dao
{
    public class CityDao: ICityDao
    {
        public void Delete(City city)
        {
            NH.Run(s => s.Delete(Mapper.Map<CityRepo>(city)));
        }

        public IList<City> List()
        {
            return Mapper.Map<IList<City>>(NH.Select(s => s.QueryOver<CityRepo>().List()));
        }

        public City Get(long id)
        {
            return Mapper.Map<City>(NH.Select(s => s.Get<CityRepo>(id)));
        }

        public City Save(City city)
        {
            var cityRepo = Mapper.Map<CityRepo>(city);
            NH.Run(s => s.SaveOrUpdate(cityRepo));
            return Mapper.Map<City>(cityRepo);
        }
    }
}
