using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Application.DTOs
{
    public class UserRegisterDto
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}

