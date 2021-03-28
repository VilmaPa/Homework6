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
        private readonly DataContext _context;

        public FruitsController(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var fruit = _context.Shops.FirstOrDefault(f => f.Id == id);

            if (fruit != null)
            {
                _context.Remove(fruit);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        [HttpGet]
        public List<Fruit> GetAll()
        {
            return _context.Fruits.ToList();
        }

        [HttpGet("{id}")]
        public Fruit GetById(int id)
        {
            return _context.Fruits.FirstOrDefault(f => f.Id == id);
        }

        [HttpPost]
        public void Create(Fruit item)
        {
            _context.Fruits.Add(item);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update(int id)
        {
            var fruit = _context.Fruits.FirstOrDefault(f => f.Id == id);

            if (fruit != null)
            {
                _context.Update(fruit);
                _context.SaveChanges();
            }
        }
        
    }
}
