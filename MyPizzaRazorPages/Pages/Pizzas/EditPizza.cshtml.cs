using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPizzaRazorPages.model;
using MyPizzaRazorPages.Services;

namespace MyPizzaRazorPages.Pages.Pizzas
{
    public class EditPizzaModel : PageModel
    {
        private IPizzaService _service;

        public EditPizzaModel(IPizzaService service)
        {
            _service = service;
        }

        [BindProperty]
        public int Number { get; set; }
        [BindProperty]
        public String Name { get; set; }
        [BindProperty]
        public String Description { get; set; }
        [BindProperty]
        public double Price { get; set; }
        [BindProperty]
        public bool IsVegan { get; set; }
        [BindProperty]
        public bool DeepPan { get; set; }
     
        
        public void OnGet(int id)
        {
            Pizza editPizza = _service.FindPizza(id);

            Number = editPizza.Number;
            Name = editPizza.Name;
            Description = editPizza.Description;    
            Price = editPizza.Price;
            IsVegan = editPizza.IsVegan;
            DeepPan = editPizza.DeepPan;

        }



        public IActionResult OnPostEdit(int id)
        {
            Pizza newValues = new Pizza(id, Name, Description, Price, IsVegan, DeepPan);

            _service.EditPizza(newValues);
            return RedirectToPage("Index");
        }

        public IActionResult OnPostFortryd()
        {
            return RedirectToPage("Index");
        }
    }
}
