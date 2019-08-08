using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<bool> Gender { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
    }
}
