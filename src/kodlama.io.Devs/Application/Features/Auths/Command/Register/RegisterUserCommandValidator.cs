using Application.Features.Auths.Constants;
using FluentValidation;

namespace Application.Features.Auths.Command.Register;

public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
{
    public RegisterUserCommandValidator()
    {
        RuleFor(p => p.FirstName)
            .NotEmpty()
            .NotNull()
            .WithMessage(UserMessages.FirstNameIsRequired);

        RuleFor(p => p.LastName)
            .NotEmpty()
            .NotNull()
            .WithMessage(UserMessages.LastNameIsRequired);

        RuleFor(p => p.Email)
            .NotEmpty()
            .NotNull()
            .WithMessage(UserMessages.EmailAddressIsRequired)
            .EmailAddress().WithMessage(UserMessages.EmailAddressIsNotValid);

        RuleFor(p => p.Password)
            .NotEmpty()
            .NotNull()
            .WithMessage(UserMessages.PasswordIsRequired);
    }
}