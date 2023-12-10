using Carbook.Application.Features.Mediator.Queries.BlogQueries;
using Carbook.Application.Features.Mediator.Results.BlogResults;
using Carbook.Application.Interfaces.BlogInterfaces;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetAllBlogWithAuthorQueryHandler : IRequestHandler<GetAllBlogWithAuthorQuery, List<GetAllBlogWithAuthorQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;
        public GetAllBlogWithAuthorQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public async Task<List<GetAllBlogWithAuthorQueryResult>> Handle(GetAllBlogWithAuthorQuery request, CancellationToken cancellationToken)
        {
            var values = _blogRepository.GetAllBlogWithAuthors();
            return values.Select(x => new GetAllBlogWithAuthorQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName=x.Author.Name,
                BlogId=x.BlogId,
                CategoryId=x.CategoryId,
                CategoryName=x.Category.Name,
                CoverImageUrl=x.CoverImageUrl,
                CreatedDate=x.CreatedDate,
                Title = x.Title,
                Description = x.Description,
                AuthorDescription=x.Author.Description,
                AuthorImageUrl= x.Author.ImageUrl
            }).ToList();
        }
    }
}
