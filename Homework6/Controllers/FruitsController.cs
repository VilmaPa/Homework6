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
    public class FruitsController : ControllerBase
    {
        private DataService _dataService;

        public FruitsController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _dataService.Fruits.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            _dataService.Fruits.Remove(item);
        }

        [HttpGet]
        public List<Fruit> GetAll()
        {
            return _dataService.Fruits;
        }

        [HttpGet("{id}")]
        public Fruit GetById(int id)
        {
            var item = _dataService.Fruits.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            return item;
        }

        [HttpPost]
        public void Create(Fruit item)
        {
            _dataService.Fruits.Add(item);
        }

        [HttpPut("{id}")]
        public void Update(Fruit item)
        {
            var itemToReplace = _dataService.Fruits.FirstOrDefault(i => i.Id == item.Id);

            if (itemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            foreach (var fruit in _dataService.Fruits)
            {
                if (fruit.Id == item.Id)
                {
                    fruit.Name = item.Name;
                }
            }
        }
    }
}
