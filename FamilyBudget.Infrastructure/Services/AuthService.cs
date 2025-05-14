using FamilyBudget.ApplicationCore.Interfaces;
using FamilyBudget.Persistence.Models;
using FamilyBudget.Persistence.Repositories.Interfaces;
using MapsterMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IGenericRepository<User> _userrepository;
        private readonly IMapper _mapper;

        public AuthService(IGenericRepository<User> userrepository, IMapper mapper)
        {
            _userrepository = userrepository;
            _mapper = mapper;
        }

        public async Task<int> LoginUser()
        {


            return 1;
        }
    }
}
