using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class Enums
    {
        public enum ResidentialType
        {
            DETACHED,
            SEMI_DETACHED,
            TERRACED,
            BUNGALOW,
            COTTAGE,
            FLAT
        }
        public enum CommericalType
        {
           OFFICE,
           WAREHOUSE,
           FACTORY,
           INDUSTRIAL_UNIT,
           RETAIL
        }

        public enum IssueSeverity
        {
            HIGH,
            MEDIUM,
            LOW
        }

        public enum StaffType
        {
            ADMIN,
            MANAGER,
            TEAM_MEMBER
        }
    }
}
