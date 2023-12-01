using Carbook.Application.Features.Mediator.Queries.SocialMediaQueries;
using Carbook.Application.Features.Mediator.Results.SocialMediaResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQuery, List<GetSocialMediaQueryResult>>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetSocialMediaQueryResult>> Handle(GetSocialMediaQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResult
            {
                SocialMediaId = x.SocialMediaId,
                Url = x.Url,
                Icon= x.Icon,
                Name = x.Name
            }).ToList();
        }
    }
}
