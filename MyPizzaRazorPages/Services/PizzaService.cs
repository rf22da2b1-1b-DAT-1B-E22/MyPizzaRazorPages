using MyPizzaRazorPages.mockData;
using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.Services
{
    public class PizzaService : IPizzaService
    {
        private MockPizzaListe _pizzaer = new MockPizzaListe();

        public void Add(Pizza pizza)
        {
            _pizzaer.Add(pizza);
        }

        public void DeletePizza(int nummer)
        {
            _pizzaer.DeletePizza(nummer);
        }

        public Pizza FindPizza(int nummer)
        {
            return _pizzaer.FindPizza(nummer);
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzaer.GetAllPizzas();
        }
    }
}
