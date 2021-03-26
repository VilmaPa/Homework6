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

    public class VegetablesController : ControllerBase
    {
        private DataService _dataService;

        public VegetablesController(DataService dataService)
        {
            _dataService = dataService;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _dataService.Vegetables.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            _dataService.Vegetables.Remove(item);
        }

        [HttpGet]
        public List<Vegetable> GetAll()
        {
            return _dataService.Vegetables;
        }

        [HttpGet("{id}")]
        public Vegetable GetById(int id)
        {
            var item = _dataService.Vegetables.FirstOrDefault(i => i.Id == id);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            return item;
        }

        [HttpPost]
        public void Create(Vegetable item)
        {
            _dataService.Vegetables.Add(item);
        }

        [HttpPut("{id}")]
        public void Update(Vegetable item)
        {
            var itemToReplace = _dataService.Vegetables.FirstOrDefault(i => i.Id == item.Id);

            if (itemToReplace == null)
            {
                throw new KeyNotFoundException();
            }
            foreach (var vegetable in _dataService.Vegetables)
            {
                if (vegetable.Id == item.Id)
                {
                    vegetable.Name = item.Name;
                }
            }
        }
    }
}
        
