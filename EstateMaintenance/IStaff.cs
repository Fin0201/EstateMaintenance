using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    internal interface IStaff
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public StaffType Type { get; set; }

    }
}
