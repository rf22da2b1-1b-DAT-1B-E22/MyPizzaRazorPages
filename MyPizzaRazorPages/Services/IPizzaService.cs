using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.Services
{
    public interface IPizzaService
    {
        public List<Pizza> GetAllPizzas();

        public void Add(Pizza pizza);
    }
}
