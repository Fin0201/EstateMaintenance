using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    internal class MinorIssue : IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }


        public MinorIssue(Guid id, strig issueName, DateTime timeStamp)
        {
            Id = Guid.NewGuid();
            Description = Description
            TimeStamp = TimeStamp;
        }

        public override string? ToString()
        {
            return $"Description: {Description} Created on: {TimeStamp}";
        }
    }
}