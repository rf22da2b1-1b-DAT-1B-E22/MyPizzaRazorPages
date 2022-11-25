using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.Services
{
    public interface IPizzaService
    {
        public List<Pizza> GetAllPizzas();

        public void Add(Pizza pizza);

        public Pizza FindPizza(int nummer);

        public void DeletePizza(int nummer);

        public void EditPizza(Pizza newValues);
    }
}
