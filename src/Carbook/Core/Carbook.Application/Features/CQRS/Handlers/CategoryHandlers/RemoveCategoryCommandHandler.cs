using Carbook.Application.Features.CQRS.Commands.CategoryCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;


namespace Carbook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        public RemoveCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveCategoryCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CategoryId);
            await _repository.RemoveAsync(value);
        }
    }
}
