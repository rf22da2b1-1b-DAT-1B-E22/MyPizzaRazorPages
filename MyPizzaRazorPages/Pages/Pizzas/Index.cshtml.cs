using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.mockData;
using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class IndexModel : PageModel
    {
        // Property til at vise pizzaer
        public List<Pizza> Pizzaer { get; set; }

        public void OnGet()
        {
            MockPizzaListe mock = new MockPizzaListe();
            Pizzaer = mock.GetAllPizzas();
        }
    }
}
