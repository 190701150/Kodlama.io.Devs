using Domain.Entities;
using FluentValidation;

namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage;

public class UpdateProgrammingLanguageCommandValidator:AbstractValidator<ProgrammingLanguage>
{
    public UpdateProgrammingLanguageCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
    }
}