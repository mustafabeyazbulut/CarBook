﻿using MediatR;

namespace Carbook.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class CreateFooterAddressCommand : IRequest
    {
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
