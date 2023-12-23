using MediatR;
using Carbook.Application.Features.Mediator.Queries.StatisticsQueries;
using Carbook.Application.Features.Mediator.Results.StatisticsResults;
using Carbook.Application.Interfaces.StatisticsInterfaces;

namespace Carbook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetBlogTitleByMaxBlogCommentQueryHandler : IRequestHandler<GetBlogTitleByMaxBlogCommentQuery, GetBlogTitleByMaxBlogCommentQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetBlogTitleByMaxBlogCommentQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogTitleByMaxBlogCommentQueryResult> Handle(GetBlogTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogTitleByMaxBlogComment();
            return new GetBlogTitleByMaxBlogCommentQueryResult
            {
                BlogTitleByMaxBlogComment = value
            };
        }   
    }
}
