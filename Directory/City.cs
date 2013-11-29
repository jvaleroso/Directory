using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    public class City
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Province Province { get; set; }
    }
}
