using FluentValidation;
using Investments.Application.Commands.VenderAtivo;

namespace Investments.Application.Validators
{
    public class VenderAtivoCommandValidator : AbstractValidator<VenderAtivoCommand>
    {
        public VenderAtivoCommandValidator()
        {
            RuleFor(c => c.Carteira.UsuarioId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do usuário é obrigatório.");
            
            RuleFor(c => c.Carteira.AtivoId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Id do ativo é obrigatório");
            
            RuleFor(c => c.Carteira.Saldo)
                .NotEmpty()
                .NotNull()
                .WithMessage("Saldo é obrigatório.")
                .GreaterThan(0)
                .WithMessage("Saldo precisa ser maior que zero.");
        }
    }
}