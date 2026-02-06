using Clientes.Application.DTOs;
using FluentValidation;

namespace Clientes.Application.Validators
{
    public class ClienteDtoValidator : AbstractValidator<ClienteRequestDto>
    {
        public ClienteDtoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Nome é obrigatório.")
                .MinimumLength(3)
                .WithMessage("Nome deve ter no mínimo 3 caracteres.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("Email é obrigatório.")
                .EmailAddress()
                .WithMessage("Email em formato inválido.");
        }
    }
}