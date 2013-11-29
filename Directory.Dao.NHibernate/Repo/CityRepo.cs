using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.Dao.NHibernate.Repo
{
    public class CityRepo
    {
        public virtual long Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ProvinceRepo Province { get; protected set; }
    }
}
