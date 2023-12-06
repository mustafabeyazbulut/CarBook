using Carbook.Application.Features.Mediator.Commands.AuthorCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;
        public CreateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Author
            {
                Description = request.Description,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
            });
        }
    }
}
