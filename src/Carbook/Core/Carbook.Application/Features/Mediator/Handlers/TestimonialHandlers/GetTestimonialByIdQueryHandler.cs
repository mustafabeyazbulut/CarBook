using Carbook.Application.Features.Mediator.Queries.TestimonialQueries;
using Carbook.Application.Features.Mediator.Results.TestimonialResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery,GetTestimonialByIdQueryResult>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.Id);
            return new GetTestimonialByIdQueryResult{
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                Comment = value.Comment,
                Title = value.Title,
                TestimonialId = value.TestimonialId,
            };
        }
    }
}
