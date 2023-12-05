﻿using Carbook.Application.Features.Mediator.Queries.TestimonialQueries;
using Carbook.Application.Features.Mediator.Results.TestimonialResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler:IRequestHandler<GetTestimonialQuery,List<GetTestimonialQueryResult>>
    {
        private readonly IRepository<Testimonial> _repository;
        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetTestimonialQueryResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResult
            {
                TestimonialId= x.TestimonialId,
                Comment= x.Comment,
                ImageUrl= x.ImageUrl,
                Name= x.Name,
                Title = x.Title
            }).ToList();
        }
    }
}
