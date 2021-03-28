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
        private readonly DataContext _context;

        public DishesController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var dish = _context.Shops.FirstOrDefault(f => f.Id == id);

            if (dish != null)
            {
                _context.Remove(dish);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        [HttpGet]
        public List<Dish> GetAll()
        {
            return _context.Dishes.ToList();
        }

        [HttpGet("{id}")]
        public Dish GetById(int id)
        {
            return _context.Dishes.FirstOrDefault(f => f.Id == id);
        }

        [HttpPost]
        public void Create(Dish item)
        {
            _context.Dishes.Add(item);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update(int id)
        {
            var dish = _context.Dishes.FirstOrDefault(f => f.Id == id);

            if (dish != null)
            {
                _context.Update(dish);
                _context.SaveChanges();
            }
        }

    }
}


