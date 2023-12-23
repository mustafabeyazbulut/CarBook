using MediatR;
using Carbook.Application.Features.Mediator.Queries.StatisticsQueries;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;
using Carbook.Application.Interfaces.StatisticsInterfaces;

namespace Carbook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAuthorCountQueryHandler : IRequestHandler<GetAuthorCountQuery, GetAuthorCountQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAuthorCountQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorCountQueryResult> Handle(GetAuthorCountQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAuthorCount();
            return new GetAuthorCountQueryResult
            {
                AuthorCount = value
            };
        }
    }
}
