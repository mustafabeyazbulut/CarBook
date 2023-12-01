using Carbook.Application.Features.Mediator.Queries.SocialMediaQueries;
using Carbook.Application.Features.Mediator.Results.SocialMediaResults;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class GetSocialMediaByIdQueryHandler : IRequestHandler<GetSocialMediaByIdQuery, GetSocialMediaByIdQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;
        public GetSocialMediaByIdQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }
        public async Task<GetSocialMediaByIdQueryResult> Handle(GetSocialMediaByIdQuery request, CancellationToken cancellationToken)
        {
            var values= await _repository.GetByIdAsync(request.Id);
            return new GetSocialMediaByIdQueryResult
            {
                Icon = values.Icon,
                Name = values.Name,
                Url = values.Url,
                SocialMediaId = values.SocialMediaId,
            };
        }
    }
}
