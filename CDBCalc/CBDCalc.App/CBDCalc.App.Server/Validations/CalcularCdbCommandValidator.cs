using FluentValidation;
using CBDCalc.App.Server.Commands;

namespace CBDCalc.App.Server.Validations
{
    public class CalcularCdbCommandValidator : AbstractValidator<CalcularCdbCommand>
    {
        public CalcularCdbCommandValidator()
        {
            RuleFor(x => x.ValorInicial).GreaterThan(0).WithMessage("O valor inicial deve ser maior que zero.");
            RuleFor(x => x.PrazoMeses).GreaterThan(1).WithMessage("O prazo em meses deve ser maior que 1.");
        }
    }
}

