﻿using Carbook.Application.Features.Mediator.Commands.AuthorCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public RemoveAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
