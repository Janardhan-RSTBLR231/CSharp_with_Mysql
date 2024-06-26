using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Details_Project.Entities
{
    public class Users:BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string PhoneNumber { get; set; }
    }
}
