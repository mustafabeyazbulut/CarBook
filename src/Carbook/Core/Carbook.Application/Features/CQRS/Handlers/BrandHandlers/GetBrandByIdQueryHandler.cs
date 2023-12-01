using Carbook.Application.Features.CQRS.Queries.BrandQueries;
using Carbook.Application.Features.CQRS.Results.BrandResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.BrandId);
            return new GetBrandByIdQueryResult
            {
                BrandId = values.BrandId,
                Name= values.Name,
            };
        }
    }
}
