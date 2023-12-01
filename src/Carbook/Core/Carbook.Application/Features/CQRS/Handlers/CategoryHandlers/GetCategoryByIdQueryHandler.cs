﻿
using Carbook.Application.Features.CQRS.Queries.CategoryQueries;
using Carbook.Application.Features.CQRS.Results.CategoryResult;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId=values.CategoryId,
                Name = values.Name,
            };
        }
    }
}
