using System.Collections.Generic;
using AutoMapper;
using Directory.Dao.NHibernate.Repo;

namespace Directory.Dao.NHibernate.Dao
{
    public class ProvinceDao: IProvinceDao
    {
        public void Delete(Province province)
        {
            NH.Run(s=>s.Delete(Mapper.Map<ProvinceRepo>(province)));
        }

        public IList<Province> List()
        {
            return Mapper.Map<IList<Province>>(NH.Select(s => s.QueryOver<ProvinceRepo>().List()));
        }

        public Province Get(long id)
        {
            return Mapper.Map<Province>(NH.Select(s => s.Get<ProvinceRepo>(id)));
        }

        public Province Save(Province province)
        {
            var provinceRepo = Mapper.Map<ProvinceRepo>(province);
            NH.Run(s=>s.SaveOrUpdate(provinceRepo));
            return Mapper.Map<Province>(provinceRepo);
        }
    }
}
