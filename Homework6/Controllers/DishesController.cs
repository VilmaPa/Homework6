using Homework6.Data;
using Homework6.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class DishesController : ControllerBase
    {
        private DataService _dataService;

        public DishesController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           var item = _dataService.Dishes.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            _dataService.Dishes.Remove(item);
        }

        [HttpGet]
        public List<Dish> GetAll()
        {
            return _dataService.Dishes;
        }

        [HttpGet("{id}")]
        public Dish GetById(int id)
        {
            var item = _dataService.Dishes.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            return item;
        }

        [HttpPost]
        public void Create(Dish item)
        {
            _dataService.Dishes.Add(item);
        }

        [HttpPut("{id}")]
        public void Update(Dish item)
        {
            var itemToReplace = _dataService.Dishes.FirstOrDefault(i => i.Id == item.Id);

            if (itemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            foreach (var dish in _dataService.Dishes)
            {
                if (dish.Id == item.Id)
                {
                    dish.Name = item.Name;
                }
            }
        }
    }
}


