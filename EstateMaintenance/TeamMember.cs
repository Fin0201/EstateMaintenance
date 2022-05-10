using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EstateMaintenance.Enums;

namespace EstateMaintenance
{
    public class TeamMember : IPerson, IStaff
    {

        public Guid Id { get; set; }

        public string Fname { get; set; }

        public string Sname { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public StaffType Type { get; set; }

        public TeamMember(string fname, string sname, string username, string password)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Username = username;
            Password = password;
            Type = StaffType.TEAM_MEMBER;
        }

        public override string? ToString()
        {
            return $"Name: {Fname} {Sname} Type: {Type}";
        }
    }
}