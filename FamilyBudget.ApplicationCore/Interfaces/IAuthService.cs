using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Interfaces
{
    public interface IAuthService
    {
        Task<int> LoginUser();
    }
}
