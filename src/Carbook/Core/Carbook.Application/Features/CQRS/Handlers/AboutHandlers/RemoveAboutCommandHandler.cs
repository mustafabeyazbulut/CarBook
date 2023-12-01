using Carbook.Application.Features.CQRS.Commands.AboutCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<About> _repository;

        public RemoveAboutCommandHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCommand command)
        {
            var value = await _repository.GetByIdAsync(command.id);
            await _repository.RemoveAsync(value);
        }
    }
}
