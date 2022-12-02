using MyPizzaRazorPages.model;
using System.Text.Json;

namespace MyPizzaRazorPages.Services
{
    public class PizzaServiceJson : IPizzaService
    {
        /*
         * FileName
         */
        private const String fileDir = @"C:\MData\pub\";
        private const String fileName = fileDir + "Pizza.json";


        /*
         * Pizzaer
         */
        private readonly List<Pizza> _pizzaer;

        public PizzaServiceJson()
        {
            _pizzaer = ReadFromJson();
        }

        

        public void Add(Pizza pizza)
        {
            _pizzaer.Add(pizza);
            SaveToJson();
        }

        

        public void DeletePizza(int nummer)
        {
            Pizza pizza = FindPizza(nummer);
            _pizzaer.Remove(pizza);
            SaveToJson();
        }

        public void EditPizza(Pizza newValues)
        {
            Pizza pizza = FindPizza(newValues.Number);

            pizza.Number = newValues.Number;
            pizza.Name = newValues.Name;
            pizza.Description = newValues.Description;
            pizza.Price = newValues.Price;
            pizza.Type = newValues.Type;
            pizza.IsVegan = newValues.IsVegan;
            pizza.DeepPan = newValues.DeepPan;

            SaveToJson();
        }

        public Pizza FindPizza(int nummer)
        {
            Pizza p = _pizzaer.Find(p => p.Number == nummer);
            if (p is not null)
            {
                return p;
            }
            throw new KeyNotFoundException();
        }

        public List<Pizza> GetAllPizzas()
        {
            return new List<Pizza>(_pizzaer);
        }



        private List<Pizza> ReadFromJson()
        {
            if (File.Exists(fileName))
            {
                using(var file = File.OpenText(fileName))
                {
                    String json = file.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Pizza>>(json);
                }
            }

            return new List<Pizza>();
        }

        private void SaveToJson()
        {
            String json = JsonSerializer.Serialize(_pizzaer);
            File.WriteAllText(fileName, json);
        }

    }
}
