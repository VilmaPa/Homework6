using Homework6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6.Data
{
    public class DataService
    {
        public List<Fruit> Fruits { get; set; }
        public List<Vegetable> Vegetables { get; set; }
        public List<Dish> Dishes { get; set; }

        public DataService()
        {
            Fruits = new List<Fruit>();
            Vegetables = new List<Vegetable>();
            Dishes = new List<Dish>();
        }
    }
    
}
