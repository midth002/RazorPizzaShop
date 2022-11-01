using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaShop.Pages
{

    // Bind all the properties to the view
    [BindProperties]
    public class CheckoutModel : PageModel
    {

       

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
        }
    }
}
