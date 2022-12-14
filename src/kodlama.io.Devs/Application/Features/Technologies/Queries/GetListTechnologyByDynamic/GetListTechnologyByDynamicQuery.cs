using Application.Features.Technologies.Models;
using Application.Features.Technologies.Queries.GetListTechnologyByDynamic;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Technologies.Queries.GetListTechnologyByDynamic;

public class GetListTechnologyByDynamicQuery:IRequest<TechnologyListModel>
{
    public Dynamic Dynamic { get; set; }
    public PageRequest PageRequest { get; set; }

    public class GetListTechnologyByDynamicQueryHandler : IRequestHandler<GetListTechnologyByDynamicQuery, TechnologyListModel>
    {

        private readonly IMapper _mapper;
        private readonly ITechnologyRepository _technologyRepository;

        public GetListTechnologyByDynamicQueryHandler(IMapper mapper, ITechnologyRepository technologyRepository)
        {
            _mapper = mapper;
            _technologyRepository = technologyRepository;
        }

        public async Task<TechnologyListModel> Handle(GetListTechnologyByDynamicQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Technology> technologies = await _technologyRepository.GetListByDynamicAsync(request.Dynamic,
                include:
                m=>m.Include(c=>c.ProgrammingLanguage)!,
                index:request.PageRequest.Page,
                size:request.PageRequest.PageSize
            );
            //dataModel
            TechnologyListModel mappedModels = _mapper.Map<TechnologyListModel>(technologies);
            return mappedModels;
        }
    }
}