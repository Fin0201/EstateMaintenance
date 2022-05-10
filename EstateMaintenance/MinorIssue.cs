using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class MinorIssue : IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public MinorIssue(string description, DateTime timestamp)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
        }
        public override string? ToString()
        {
            return $"Description: {Description} Created On: {Timestamp}";
        }
    }
}