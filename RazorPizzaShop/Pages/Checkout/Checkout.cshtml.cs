using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzaShop.Pages
{

    // Bind all the properties to the view
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

       

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            // If no pizza name, add the name to be custom
            if(string.IsNullOrEmpty(PizzaName))
            {
                PizzaName = "Custom";
            }

            // If no pizza image than add the create pizza image 
            if(string.IsNullOrEmpty(ImageTitle))
            {
                ImageTitle = "Create";
            }




        }
    }
}
