﻿using Carbook.Application.Features.CQRS.Commands.CarCommands;
using Carbook.Application.Features.CQRS.Handlers.CarHandlers;
using Carbook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;

        public CarController(CreateCarCommandHandler createCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, 
            RemoveCarCommandHandler removeCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, 
            GetCarQueryHandler getCarQueryHandler)
        {
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> CarList()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var values = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok("Add new Car.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveCar(int id)
        {
            await _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return Ok("Delete Car!");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok("Update Car.");
        }
    }
}