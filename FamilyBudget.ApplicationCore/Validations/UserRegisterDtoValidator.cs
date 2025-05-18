using FamilyBudget.Application.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyBudget.ApplicationCore.Validations
{
    public class UserRegisterDtoValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterDtoValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email обязателен")
                .EmailAddress().WithMessage("Невалидный email");

            RuleFor(x => x.PasswordHash)
                .NotEmpty().WithMessage("Пароль обязателен")
                .MinimumLength(8).WithMessage("Минимум 8 символов");

            RuleFor(x => x.ConfirmPasswordHash)
                .NotEmpty().WithMessage("Подтверждение пароля обязательно")
                .Equal(x => x.PasswordHash).WithMessage("Пароли не совпадают");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Имя обязательно")
                .Matches("^[А-Яа-яA-Za-z]+$").WithMessage("Имя может содержать только буквы");

            RuleFor(x => x.SecondName)
                .NotEmpty().WithMessage("Фамилия обязательна")
                .Matches("^[А-Яа-яA-Za-z]+$").WithMessage("Фамилия может содержать только буквы");
        }
    }
}
