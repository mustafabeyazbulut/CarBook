using Carbook.Application.Features.Mediator.Queries.BlogQueries;
using Carbook.Application.Features.Mediator.Results.BlogResults;
using Carbook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAuthorByBlogIdQueryHandler:IRequestHandler<GetAuthorByBlogIdQuery,List<GetAuthorByBlogIdQueryResult>>
    {
        private readonly IBlogRepository _repository;
        public GetAuthorByBlogIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAuthorByBlogIdQueryResult>> Handle(GetAuthorByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAuthorByBlogId(request.Id);
            return values.Select(x => new GetAuthorByBlogIdQueryResult
            {
                BlogId = x.BlogId,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                AuthorDescription = x.Author.Description,
                AuthorImageUrl = x.Author.ImageUrl
            }).ToList();
        }
    }
}
