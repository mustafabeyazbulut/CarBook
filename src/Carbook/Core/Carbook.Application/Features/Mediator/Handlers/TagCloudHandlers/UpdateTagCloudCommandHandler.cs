using Carbook.Application.Features.Mediator.Commands.TagCloudCommands;
using Carbook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;

namespace Carbook.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;
        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.TagCloudId);
            value.BlogId = request.BlogId;
            value.Title = request.Title;
            await _repository.UpdateAsync(value);
        }
    }
}
