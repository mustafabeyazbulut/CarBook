using Carbook.Application.Features.Mediator.Queries.BlogQueries;
using Carbook.Application.Features.Mediator.Results.BlogResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdQueryResult>
    {
        private readonly IRepository<Blog> _repository;
        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }
        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var values= await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                AuthorId= values.AuthorId,
                BlogId= values.BlogId,
                CategoryId= values.CategoryId,
                CoverImageUrl= values.CoverImageUrl,
                CreatedDate= values.CreatedDate,
                Title = values.Title,
                Description=values.Description,
            };
        }
    }
}
