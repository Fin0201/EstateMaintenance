using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    public class MajorIssue : IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public IssueSeverity Severity { get; set; }

        public bool Open { get; set; }

        public List<Purchase> PurchaseList { get; set; }


        public List<TimeLog> TimeLogList { get; set; }

        public MajorIssue(string description, IssueSeverity severity)
        {
            Id = Guid.NewGuid();
            Description = description;
            Timestamp = DateTime.Now;
            Severity = severity;
            Open = true;
            PurchaseList = new List<Purchase>();
            TimeLogList = new List<TimeLog>();
        }

        public override string? ToString()
        {
            return $"Description: {Description} Priority: {Severity} Created On: {Timestamp}";
        }
    }
}