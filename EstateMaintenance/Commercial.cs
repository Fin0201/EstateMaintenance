using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    public class Commercial : IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string BusinessName { get; set; }
        public CommericalType Type { get; set; }
        public double SizeInSqFoot { get; set; }

        public Commercial(string address, string businessName, CommericalType type, double sizeInSqFoot)
        {
            Id = Guid.NewGuid();
            Address = address;
            BusinessName = businessName;
            Type = type;
            SizeInSqFoot = sizeInSqFoot;
        }

        public override string? ToString()
        {
            return $"Address: {Address} Name: {BusinessName} Type: {Type} Size: {SizeInSqFoot}";
        }
    }
}
