using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Cost { get; set; }
        public DateTime CreatedOn { get; set; }
        public TeamMember? CreatedBy { get; set; }

        public Purchase(Guid id, string description, string cost, DateTime createdOn, TeamMember? createdBy)
        {
            Id = id;
            Description = description;
            Cost = cost;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
        }

        public override string ToString()
        {
            return $"ID: {Id} Desc: {Description} Cost: £{Cost} Created on: {CreatedOn}";
        }
    }
}
