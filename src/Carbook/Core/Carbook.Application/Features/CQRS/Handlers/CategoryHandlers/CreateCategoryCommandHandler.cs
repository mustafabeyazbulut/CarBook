using Carbook.Application.Features.CQRS.Commands.CategoryCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Category> _repository;
        public CreateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCategoryCommand command)
        {
            await _repository.CreateAsync(new Category()
            {
                Name = command.Name,
            });
        }
    }
}
