﻿using Carbook.Application.Features.Mediator.Queries.AuthorQueries;
using Carbook.Application.Features.Mediator.Results.AuthorResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetAuthorQueryHandler:IRequestHandler<GetAuthorQuery,List<GetAuthorQueryResult>>
    {
        private readonly IRepository<Author> _repository;
        public GetAuthorQueryHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorQueryResult>> Handle(GetAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name=x.Name
            }).ToList();
        }
    }
}
