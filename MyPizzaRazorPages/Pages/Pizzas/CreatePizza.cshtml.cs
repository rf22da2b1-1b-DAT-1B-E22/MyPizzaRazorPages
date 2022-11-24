using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.mockData;
using MyPizzaRazorPages.model;
using MyPizzaRazorPages.Services;
using System.ComponentModel.DataAnnotations;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class CreatePizzaModel : PageModel
    {
        private IPizzaService _service;



        // properties
        [BindProperty]
        public Pizza  Pizza { get; set; }



        [BindProperty]
        [Required (ErrorMessage="Der skal være en pris")]
        [Range(0,1000, ErrorMessage ="Prisen må ikke være negativ")]
        public double Price { get; set; }


        public CreatePizzaModel(IPizzaService service)
        {
            _service = service;
        }




        // når siden vises
        public void OnGet()
        {
        }


        // Når vi trykker på en knap
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Pizza.Type = MenuType.Pizza;
            Pizza.Price = Price;

            //MockPizzaListe mock = new MockPizzaListe();
            _service.Add(Pizza);

            return RedirectToPage("Index");
        }
    }
}
