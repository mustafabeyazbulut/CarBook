using Carbook.Application.Features.CQRS.Commands.CarCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public RemoveCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);
            await _repository.RemoveAsync(value);
        }
    }
}
