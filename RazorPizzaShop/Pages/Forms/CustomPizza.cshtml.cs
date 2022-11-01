using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {

        [BindProperty]

        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }   
   


        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.GreenPeppers) PizzaPrice += 1;
            if (Pizza.Olives) PizzaPrice += 1;
            if (Pizza.Peperoni) PizzaPrice += 2;
            if (Pizza.Sausage) PizzaPrice += 2;
            if (Pizza.Ham) PizzaPrice += 2;
            if (Pizza.CanadianBacon) PizzaPrice += 2;
            if (Pizza.Beef) PizzaPrice += 2;
            if (Pizza.Pineapple) PizzaPrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});

        }
    }
}
