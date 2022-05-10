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

        public bool Open { get; set; }

        public List<Purchase> PurchaseList { get; set; }

        public List<TimeLog> TimeLogList { get; set; }

        public MinorIssue(string description)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
            Open = true;
            PurchaseList = new List<Purchase>();
            TimeLogList = new List<TimeLog>();
        }
        public override string? ToString()
        {
            return $"Description: {Description} Created On: {Timestamp}";
        }
    }
}