using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.mockData;
using MyPizzaRazorPages.model;
using MyPizzaRazorPages.Services;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class IndexModel : PageModel
    {
        private IPizzaService _service;

        public IndexModel(IPizzaService service)
        {
            _service = service;
        }

        // Property til at vise pizzaer
        public List<Pizza> Pizzaer { get; set; }

        public void OnGet()
        {
            //MockPizzaListe mock = new MockPizzaListe();
            Pizzaer = _service.GetAllPizzas();
        }
    }
}
