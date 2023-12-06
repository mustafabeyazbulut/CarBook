﻿using MediatR;

namespace Carbook.Application.Features.Mediator.Commands.AuthorCommands
{
    public class RemoveAuthorCommand:IRequest
    {
        public int Id { get; set; }
        public RemoveAuthorCommand(int id)
        {
            Id = id;
        }
    }
}
