using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() {Name = "Playstation", Price = 500},
            new Product() {Name = "Coffee Machine", Price = 25},
            new Product() {Name = "Comic Books", Price = 15},
            new Product() {Name = "Piano", Price = 1200}
        };
        

        public List<Product> LoadData()
        {
            Console.WriteLine("Reading data from List Database.");

            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data to List Database.");
        }
    }
}
