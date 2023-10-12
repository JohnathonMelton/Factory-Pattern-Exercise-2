namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to access?");
            Console.WriteLine("");
            Console.Write("Options: List, SQL, or Mongo. Choice:");

            var userInput = Console.ReadLine();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name} Price: {product.Price}");
            }




        }
    }
}
