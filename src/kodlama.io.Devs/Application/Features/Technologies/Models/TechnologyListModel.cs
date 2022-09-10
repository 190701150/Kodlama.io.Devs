using Application.Features.ProgrammingLanguages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.Technologies.Models;

public class TechnologyListModel:BasePageableModel
{
    public IList<ProgrammingLanguageListDto> Items { get; set; }
}