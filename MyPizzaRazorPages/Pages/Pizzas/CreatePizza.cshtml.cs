using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.mockData;
using MyPizzaRazorPages.model;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class CreatePizzaModel : PageModel
    {
        // properties
        [BindProperty]
        public Pizza  Pizza { get; set; }



        // når siden vises
        public void OnGet()
        {
        }


        // Når vi trykker på en knap
        public IActionResult OnPost()
        {
            Pizza.Type = MenuType.Pizza;

            MockPizzaListe mock = new MockPizzaListe();
            mock.Add(Pizza);


            return RedirectToPage("Index");
        }
    }
}
