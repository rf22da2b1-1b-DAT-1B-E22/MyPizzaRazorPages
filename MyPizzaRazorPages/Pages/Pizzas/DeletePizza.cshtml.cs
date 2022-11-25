using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.model;
using MyPizzaRazorPages.Services;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class DeletePizzaModel : PageModel
    {
        private IPizzaService _service;

        //[BindProperty]
        public Pizza SletPizza { get; set; }

        public DeletePizzaModel(IPizzaService service)
        {
            _service = service;
        }
        public void OnGet(int id)
        {
            SletPizza = _service.FindPizza(id);
        }

        public IActionResult OnPostSlet(int id)
        {
            _service.DeletePizza(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }

    }
}
