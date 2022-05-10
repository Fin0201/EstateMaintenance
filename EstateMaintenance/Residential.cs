using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    internal class Residential : IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public ResidentialType Type { get; set; }
        public int NumberOfBedrooms { get; set; }
        public Tenant CurrentTenant { get; set; }
        public List<IIssue> Issues { get; set; }
        public Residential(string address, ResidentialType type, int numberOfBedrooms, Tenant tenant)
        {
            Id = Guid.NewGuid();
            Address = address;
            Type = type;
            NumberOfBedrooms = numberOfBedrooms;
            CurrentTenant = tenant;
            Issues = new List<IIssue>();
        }

        public override string? ToString()
        {
            return $"Address: {Address} Type: {Type} Number Of Bedrooms: {NumberOfBedrooms}";
        }
    }
}