using Carbook.Application.Features.Mediator.Commands.FooterAddressCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.FooterAddressHandlers
{
    public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommand>
    {
        private readonly IRepository<FooterAdress> _repository;

        public RemoveFooterAddressCommandHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveFooterAddressCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FooterAdressId);
            await _repository.RemoveAsync(value);
        }
    }
}
