using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public class Province
    {
        public Province()
        {
            Cities = new List<City>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<City> Cities { get; private set; } 
    }
}
