using FluentValidation;
using Investments.Application.Commands.CadastrarAtivo;

namespace Investments.Application.Validators
{
    public class CadastrarAtivoCommandValidator : AbstractValidator<CadastrarAtivoCommand>
    {
        public CadastrarAtivoCommandValidator()
        {
            RuleFor(a => a.Nome)
                .MaximumLength(255)
                .WithMessage("Tamanho máximo do nome do ativo é de 255 caracteres")
                .NotEmpty()
                .NotNull()                
                .WithMessage("Nome do ativo é obrigatório.");

            RuleFor(a => a.Tipo)
                .IsInEnum()
                .WithMessage("Valor não é válido.");
        }
    }
}