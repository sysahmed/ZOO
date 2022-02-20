using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ZOO.Business.Abstract;
using ZOO.Entities.Concrete;

namespace ZOO.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        IAnimalService _animalService;
        Elephants elephants;
        Lions lions;
        Monkeys monkeys;
        Random random;
        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
            random = new Random();
        }
        [HttpPost]
        public IActionResult AddAnimal(BaseAnimal animal)
        {
            for (int i = 0; i < 5; i++)
            {
                _animalService.Add(new Monkeys { AnimalId = i + 1, AnimalHealtPoints = 100, AnimalName = "Monkeys" });
                _animalService.Add(new Lions { AnimalId = i + 5, AnimalHealtPoints = 100, AnimalName = "Lions" });
                _animalService.Add(new Elephants { AnimalId = i + 10, AnimalHealtPoints = 100, AnimalName = "Elephants" });
            }
            return Ok();
        }
        [HttpDelete]
        public IActionResult AnimalHungry(BaseAnimal animal)
        {
            List<BaseAnimal> _animalList = _animalService.GetList().Data;
            foreach (var item in _animalList)
            {
                item.AnimalHealtPoints = item.AnimalHealtPoints - random.Next(0, 20);
                _animalService.Update(item);
            }
            return Ok();
        }
        [HttpPut]
        public IActionResult AnimalEating()
        {
            List<BaseAnimal> _animalList = _animalService.GetList().Data;
            foreach (var item in _animalList)
            {
                item.AnimalHealtPoints = item.AnimalHealtPoints + random.Next(5, 25);
                _animalService.Update(item);
            }
            return Ok();
        }
        [HttpGet]
        public IActionResult GetAnimal()
        {
            return Ok(_animalService.GetList().Data);
        }
    }
}
