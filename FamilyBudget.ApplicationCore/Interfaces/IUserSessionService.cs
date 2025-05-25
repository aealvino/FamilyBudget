using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Interfaces
{
    public interface IUserSessionService
    {
        bool IsLoggedIn { get; set; }
        int? UserId { get; }
        void SetLoggedIn(bool value, int userId);
    }

}
