using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }

        public Member(int memberId, string name)
        {
            MemberID = memberId;
            Name = name;
        }
    }
}
