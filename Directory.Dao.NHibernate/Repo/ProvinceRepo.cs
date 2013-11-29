using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.Dao.NHibernate.Repo
{
    public class ProvinceRepo
    {
        public virtual long Id { get; set; }
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual IList<CityRepo> Cities { get; protected set; } 
    }
}
 