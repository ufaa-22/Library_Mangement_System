using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Librarian
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public Librarian(int employeeId, string name)
        {
            EmployeeID = employeeId;
            Name = name;
        }
    }
}
