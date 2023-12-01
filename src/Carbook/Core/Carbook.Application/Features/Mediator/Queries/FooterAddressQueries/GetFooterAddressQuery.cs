using Carbook.Application.Features.Mediator.Results.FooterAddressResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.FooterAddressQueries
{
    public class GetFooterAddressQuery:IRequest<List<GetFooterAddressQueryResult>>
    {
    }
}
