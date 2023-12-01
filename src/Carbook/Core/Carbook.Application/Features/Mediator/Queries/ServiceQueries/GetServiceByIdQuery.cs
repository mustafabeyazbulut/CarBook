using Carbook.Application.Features.Mediator.Results.ServiceResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery:IRequest<GetServiceByIdQueryResult>
    {
        public int Id { get; set; }
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}
