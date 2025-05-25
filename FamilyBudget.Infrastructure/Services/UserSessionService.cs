using FamilyBudget.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Infrastructure.Services
{
    public class UserSessionService : IUserSessionService
    {
        public bool IsLoggedIn { get; set; }
        public int? UserId { get; private set; }
        public void SetLoggedIn(bool value, int userId)
        {
            IsLoggedIn = value;
            UserId = userId;
        }
    }
}
