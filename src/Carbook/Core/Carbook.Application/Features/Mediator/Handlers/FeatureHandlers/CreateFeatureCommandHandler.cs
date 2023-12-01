﻿using Carbook.Application.Features.Mediator.Commands.FeatureCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public CreateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Feature
            {
                Name=request.Name,
            });
        }
    }
}
