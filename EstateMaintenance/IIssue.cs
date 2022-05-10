using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public interface IIssue
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public DateTime Timestamp { get; set; }

        public bool Open { get; set; }

        public List<Purchase> PurchaseList { get; set; }

        public List<TimeLog> TimeLogList { get; set; }

    }
}