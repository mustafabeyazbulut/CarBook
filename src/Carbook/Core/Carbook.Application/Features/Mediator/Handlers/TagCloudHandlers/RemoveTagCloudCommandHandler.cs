﻿using Carbook.Application.Features.Mediator.Commands.TagCloudCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class RemoveTagCloudCommandHandler : IRequestHandler<RemoveTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;
        public RemoveTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveTagCloudCommand request, CancellationToken cancellationToken)
        {
            var value=await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
