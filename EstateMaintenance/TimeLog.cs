using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    public class TimeLog
    {
        public Guid Id { get; set; }

        public int AmountInMins { get; set; }

        public DateTime LoggedOn { get; set; }

        public TeamMember? MemberOfTeam { get; set; }

        public TimeLog(int amountInMins, TeamMember? memberOfTeam)
        {
            Id = Guid.NewGuid();
            AmountInMins = amountInMins;
            LoggedOn = DateTime.Now;
            MemberOfTeam = memberOfTeam;
        }

        public override string? ToString()
        {
            return $"ID: {Id} Amount in minutes: {AmountInMins} Team Member: {MemberOfTeam} Logged On: {LoggedOn}";
        }
    }


}