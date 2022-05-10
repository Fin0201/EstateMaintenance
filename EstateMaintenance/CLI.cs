using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;

namespace EstateMaintenance
{
    public static class CLI
    {
        static void Main(string[] args)
        {
            EstateMaintenanceSystem es = new EstateMaintenanceSystem("Fin's Furniture, but we actually sell properties instead");

            var prop = Prompt.Select("What type of property do you wish to add?", new[] { "Resedential", "Commercial" });

            var address = Prompt.Input<string>("Address");

            var fname = Prompt.Input<string>("Tenant First Name");

            var lname = Prompt.Input<string>("Tenant Last Name");

            



















            Tenant tenant = new Tenant(fname, lname);
        }
    }
}
