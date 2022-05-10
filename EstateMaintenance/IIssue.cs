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



    }
}