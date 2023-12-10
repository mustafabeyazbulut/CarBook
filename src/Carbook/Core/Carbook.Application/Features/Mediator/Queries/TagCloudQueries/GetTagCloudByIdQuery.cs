﻿using Carbook.Application.Features.Mediator.Results.TagCloudResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudByIdQuery:IRequest<GetTagCloudByIdQueryResult>
    {
        public int Id { get; set; }
        public GetTagCloudByIdQuery(int id)
        {
            Id = id;
        }
    }
}
