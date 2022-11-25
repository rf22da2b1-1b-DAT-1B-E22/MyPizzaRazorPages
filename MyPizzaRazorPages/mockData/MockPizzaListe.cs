using Microsoft.AspNetCore.Server.IIS.Core;
using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.mockData
{
    public class MockPizzaListe
    {
        // instans felt med default pizzaer
        private List<Pizza> _pizzaer = new List<Pizza>()
        {
            new Pizza(10, "PetersPizza", "Very special", 54, false, false),
            new Pizza(12, "JakobPizza", "Very Hot", 51, false, false),
            new Pizza(13, "Vegan", "only ....", 49, true, false),
            new Pizza(15, "Vesio", "...", 65, false, true)
        };


        public List<Pizza> GetAllPizzas()
        {
            return new List<Pizza>(_pizzaer);
        }

        public void Add(Pizza pizza)
        {
            _pizzaer.Add(pizza);

        }

        public void DeletePizza(int nummer)
        {
            Pizza sletPizza = FindPizza(nummer);
            _pizzaer.Remove(sletPizza);
        }

        public Pizza FindPizza(int nummer)
        {
            foreach(Pizza p in _pizzaer)
            {
                if (p.Number == nummer)
                {
                    return p;
                }
            }

            throw new KeyNotFoundException();
        }

        public void EditPizza(Pizza newValues)
        {
            Pizza editPizza = FindPizza(newValues.Number);

            editPizza.Name = newValues.Name;
            editPizza.Description = newValues.Description;
            editPizza.Number = newValues.Number;
            editPizza.Price = newValues.Price;
            editPizza.IsVegan = newValues.IsVegan;
            editPizza.DeepPan = newValues.DeepPan;
        }
    }
}
