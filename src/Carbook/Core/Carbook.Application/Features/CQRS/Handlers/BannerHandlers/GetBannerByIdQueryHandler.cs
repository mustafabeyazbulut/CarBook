﻿using Carbook.Application.Features.CQRS.Queries.BannerQueries;
using Carbook.Application.Features.CQRS.Results.BannerResults;
using Carbook.Application.Interfaces;


namespace Carbook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerId=values.BannerId,
                Description=values.Description,
                Title=values.Title,
                VideoDescription=values.VideoDescription,
                VideoUrl = values.VideoUrl
            };
        }
    }
}
