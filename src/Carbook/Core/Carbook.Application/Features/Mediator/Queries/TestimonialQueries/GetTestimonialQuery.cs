using Carbook.Application.Features.Mediator.Results.TestimonialResults;
using MediatR;

namespace Carbook.Application.Features.Mediator.Queries.TestimonialQueries
{
    public class GetTestimonialQuery:IRequest<List<GetTestimonialQueryResult>>
    {
    }
}
