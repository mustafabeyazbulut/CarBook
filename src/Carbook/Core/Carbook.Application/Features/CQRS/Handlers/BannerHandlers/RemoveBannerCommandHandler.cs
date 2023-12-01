using Carbook.Application.Features.CQRS.Commands.BannerCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;

namespace Carbook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveBannerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.id);
            await _repository.RemoveAsync(value);
        }
    }
}
