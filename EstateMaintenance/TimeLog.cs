using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateMaintenance
{
    internal class TimeLog
    {
        public Guid Id { get; set; }

        public int AmountInMins { get; set; }

        public DateTime LoggedOn { get; set; }

        public TeamMember? MemberOfTeam { get; set; }

        public TimeLog(Guid id, int amountInMins, DateTime loggedOn, TeamMember? memberOfTeam)
        {
            Id = id;
            AmountInMins = amountInMins;
            LoggedOn = loggedOn;
            MemberOfTeam = memberOfTeam;
        }

        public override string ToString()
        {
            return $"ID: {Id} Amount in minutes: {AmountInMins} Team Member: {MemberOfTeam} Logged On: {LoggedOn}";
        }
    }
}
