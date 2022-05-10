using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class Tenant
    {
        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public Tenant(string fname, string sname)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
        }
    }
}
