﻿using Carbook.Application.Features.Mediator.Commands.LocationCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly IRepository<Location> _repository;
        public RemoveLocationCommandHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
