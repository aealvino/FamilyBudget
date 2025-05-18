using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.DTOs
{
    public class UserLoginDTO
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
