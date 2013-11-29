using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.Service
{
    public interface ICityService
    {
        void Delete(City city);
        IList<City> List();
        City Get(long id);
        City Save(City city);
    }
}
