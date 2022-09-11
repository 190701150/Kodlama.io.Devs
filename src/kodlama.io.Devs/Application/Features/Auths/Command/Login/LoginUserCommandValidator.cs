using Application.Features.Auths.Constants;
using FluentValidation;

namespace Application.Features.Auths.Command.Login;

public class LoginUserCommandValidator: AbstractValidator<LoginUserCommand>
{
    public LoginUserCommandValidator()
    {
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