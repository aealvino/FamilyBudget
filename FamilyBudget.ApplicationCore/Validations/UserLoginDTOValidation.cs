using FamilyBudget.ApplicationCore.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Validations
{
    public class UserLoginDTOValidation : AbstractValidator<UserLoginDTO>
    {
        public UserLoginDTOValidation()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email обязателен")
                .EmailAddress().WithMessage("Невалидный email");

            RuleFor(x => x.PasswordHash)
                .NotEmpty().WithMessage("Пароль обязателен")
                .MinimumLength(8).WithMessage("Минимум 8 символов");
        }
    }
}
