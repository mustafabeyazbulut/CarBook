﻿using Carbook.Application.Features.Mediator.Queries.TagCloudQueries;
using Carbook.Application.Features.Mediator.Results.TagCloudResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQuery, GetTagCloudByIdQueryResult>
    {
        private readonly IRepository<TagCloud> _repository;
        public GetTagCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }
        public async Task<GetTagCloudByIdQueryResult> Handle(GetTagCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.Id);
            return new GetTagCloudByIdQueryResult
            {
                BlogId = value.BlogId,
                TagCloudId = value.TagCloudId,
                Title= value.Title,
            };
        }
    }
}
