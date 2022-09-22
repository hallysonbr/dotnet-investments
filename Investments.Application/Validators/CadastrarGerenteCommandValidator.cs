using System;
using System.Text.RegularExpressions;
using FluentValidation;
using Investments.Application.Commands.CadastrarGerente;

namespace Investments.Application.Validators
{
    public class CadastrarGerenteCommandValidator : AbstractValidator<CadastrarGerenteCommand>
    {
        public CadastrarGerenteCommandValidator()
        {
            RuleFor(u => u.Usuario.Nome)
                .MaximumLength(255)
                .WithMessage("O tamanho máximo do nome é de 255 caracteres.")
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório.");
            
            RuleFor(u => u.Usuario.Email)
                .MaximumLength(255)
                .WithMessage("O tamanho máximo do e-mail é de 255 caracteres.")
                .NotEmpty()
                .NotNull()
                .WithMessage("E-mail é obrigatório.")
                .EmailAddress()
                .WithMessage("E-mail não válido.");

            RuleFor(u => u.Usuario.Password)
                .Must(ValidPassword)
                .WithMessage("Senha deve conter pelo menos 6 caracteres, um número, uma letra maiúscula, uma minúscula, e um caractere especial");

            RuleFor(u => u.Usuario.DataNascimento)
                .NotEmpty()
                .NotNull()
                .WithMessage("Data de Nascimento é Obrigatória")
                .Must(ValidBirthDate)
                .WithMessage("Data de Nascimento inválida.");
        }

        private bool ValidBirthDate(DateTime dataNascimento)
        {
           var condition = (dataNascimento.Year >= 1900) &&
                           (dataNascimento.Month <= 12) &&
                           (
                             (DateTime.DaysInMonth(dataNascimento.Year, dataNascimento.Month) == 30 
                                                && dataNascimento.Day <= 30) ||
                             (DateTime.DaysInMonth(dataNascimento.Year, dataNascimento.Month) == 31 
                                                && dataNascimento.Day <= 31) ||
                             (dataNascimento.Month == 2 && dataNascimento.Day <= 29)
                           );
           
           return condition;
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex(@"^.*(?=.{6,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$");

            return regex.IsMatch(password);
        }
    }
}