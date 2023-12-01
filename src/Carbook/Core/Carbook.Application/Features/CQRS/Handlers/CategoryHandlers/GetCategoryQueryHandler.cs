using Carbook.Application.Features.CQRS.Results.CategoryResult;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCategoryQueryResult
            {
                CategoryId=x.CategoryId,
                Name = x.Name,
            }).ToList();
        }
    }
}
