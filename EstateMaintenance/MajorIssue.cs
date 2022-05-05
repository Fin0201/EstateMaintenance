using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    internal class MajorIssue : IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }

        public IssueSeverity Severity { get; set; }

        public MajorIssue(Guid id, strig issueName, DateTime timeStamp)
        {
            Id = Guid.NewGuid();
            Description = description
            TimeStamp = timeStamp;
            Severity = severity;
        }

        public override string? ToString()
        {
            return $"Description: {Description} Priority: {Severity} Created on: {TimeStamp}";
        }
    }
}