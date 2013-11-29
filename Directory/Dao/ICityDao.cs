using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.Dao
{
    public interface ICityDao
    {
        void Delete(City city);
        IList<City> List();
        City Get(long id);
        City Save(City city);
    }
}
