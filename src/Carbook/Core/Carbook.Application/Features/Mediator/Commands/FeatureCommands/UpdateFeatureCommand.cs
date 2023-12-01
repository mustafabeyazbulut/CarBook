﻿using MediatR;

namespace Carbook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand:IRequest
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
