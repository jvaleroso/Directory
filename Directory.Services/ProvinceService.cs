using System.Collections.Generic;
using Directory.Dao;
using Directory.Service;

namespace Directory.Services
{
    public class ProvinceService: IProvinceService
    {
        private readonly IProvinceDao _provinceDao;

        public ProvinceService(IProvinceDao provinceDao)
        {
            _provinceDao = provinceDao;
        }

        public void Delete(Province province)
        {
            _provinceDao.Delete(province);
        }

        public IList<Province> List()
        {
            return _provinceDao.List();
        }

        public Province Get(long id)
        {
            return _provinceDao.Get(id);
        }

        public Province Save(Province province)
        {
            return _provinceDao.Save(province);
        }
    }
}
