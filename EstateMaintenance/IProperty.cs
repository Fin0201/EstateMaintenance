using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public interface IProperty
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public Tenant CurrentTenant { get; set; }
        public List<IIssue> Issues { get; set; }

    }
}