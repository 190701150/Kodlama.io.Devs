using Application.Features.ProgrammingLanguages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.ProgrammingLanguages.Models;

public class ProgrammingLanguageListModel
{
    public IList<ProgrammingLanguageListDto> Items { get; set; }
}