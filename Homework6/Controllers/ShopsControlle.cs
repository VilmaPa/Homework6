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
    public class ShopsControlle : ControllerBase
    {
        private readonly DataContext _context;

        public ShopsControlle(DataContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet]
        public List<Shop> GetAll()
        {
            return _context.Shops.ToList();
        }
        [HttpGet("{id}")]
        public Shop GetById(int id)
        {
            return _context.Shops.FirstOrDefault(s => s.Id == id);
        }

        [HttpPost]
        public void Create(Shop item)
        {
            _context.Shops.Add(item);
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update(int id)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.Id == id);

            if (shop != null)
            {
                _context.Update(shop);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var shop = _context.Shops.FirstOrDefault(s => s.Id ==id);

            if (shop != null)
            {
                _context.Remove(shop);
                _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException();
            }

           
        }

    }
}
