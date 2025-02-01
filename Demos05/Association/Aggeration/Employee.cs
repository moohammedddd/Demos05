using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos05.Association.Aggeration
{
    internal class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName {  get; set; }

        public int Age { get; set; }

        public decimal Salary { get; set; }
    }
}
