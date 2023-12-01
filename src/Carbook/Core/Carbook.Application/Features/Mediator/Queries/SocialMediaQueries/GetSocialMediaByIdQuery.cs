using Carbook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery:IRequest<GetSocialMediaByIdQueryResult>
    {
        public int Id { get; set; }
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }
    }
}
