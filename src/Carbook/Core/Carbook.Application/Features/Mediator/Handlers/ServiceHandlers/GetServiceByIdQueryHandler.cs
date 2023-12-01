using Carbook.Application.Features.Mediator.Queries.ServiceQueries;
using Carbook.Application.Features.Mediator.Results.PricingResults;
using Carbook.Application.Features.Mediator.Results.ServiceResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
    {
        private readonly IRepository<Service> _repository;
        public GetServiceByIdQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }
        public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetServiceByIdQueryResult
            {
                Description = values.Description,
                IconUrl = values.IconUrl,
                Title = values.Title,
                ServiceId=values.ServiceId,
            };
        }
    }
}
