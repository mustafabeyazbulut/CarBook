﻿using Carbook.Application.Features.CQRS.Commands.CarCommands;
using Carbook.Application.Features.CQRS.Handlers.CarHandlers;
using Carbook.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carbook.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;
        private readonly GetLast5CarsWithBrandQueryHandler _getLast5CarsWithBrandQueryHandler;
        public CarsController(CreateCarCommandHandler createCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, 
            RemoveCarCommandHandler removeCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, 
            GetCarQueryHandler getCarQueryHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler,
            GetLast5CarsWithBrandQueryHandler getLast5CarsWithBrandQueryHandler)
        {
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
            _getLast5CarsWithBrandQueryHandler = getLast5CarsWithBrandQueryHandler;
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
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var values =  _getCarWithBrandQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("GetLast5CarsWithBrand")]
        public IActionResult GetLast5CarsWithBrand()
        {
            var values = _getLast5CarsWithBrandQueryHandler.Handle();
            return Ok(values);
        }
    }
}
