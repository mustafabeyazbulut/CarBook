﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Application.Features.Mediator.Results.LocationResults
{
    public class GetLocationByIdQueryResult
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
