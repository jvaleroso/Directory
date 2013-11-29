using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.Service
{
    public interface IProvinceService
    {
        void Delete(Province province);
        IList<Province> List();
        Province Get(long id);
        Province Save(Province province);
    }
}
