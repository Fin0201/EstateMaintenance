using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    internal interface IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }

    }
}
