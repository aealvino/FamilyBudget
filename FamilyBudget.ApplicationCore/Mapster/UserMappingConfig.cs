using FamilyBudget.Application.DTOs;
using FamilyBudget.Persistence.Models;
using Mapster;

namespace FamilyBudget.Application.Mappings;

public class UserMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<UserRegisterDto, User>()
            .Map(dest => dest.PasswordHash, src => "")
            .Ignore(dest => dest.Id)
            .Ignore(dest => dest.FamilyId)
            .Ignore(dest => dest.RoleId)
            .Ignore(dest => dest.Family)
            .Ignore(dest => dest.Role)
            .Ignore(dest => dest.Expences)
            .Ignore(dest => dest.Incomes)
            .Map(dest => dest.Balance, _ => 0m);
    }
}
