using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class MemberManagement
    {
        private List<Member> members = new List<Member>();

        public void RegisterMember(Member member)
        {
            members.Add(member);
        }

        public void DisplayAllMembers()
        {
            foreach (var member in members)
            {
                Console.WriteLine($"MemberID: {member.MemberID}, Name: {member.Name}");
            }
        }
    }
}
