using Carbook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery:IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}
