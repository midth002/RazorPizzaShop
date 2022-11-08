using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaShop.Data;
using RazorPizzaShop.Models;

namespace RazorPizzaShop.Pages
{

    // Bind all the properties to the view
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

       

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }


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

            PizzaOrder pizzaOrder = new PizzaOrder(); 
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.Orders.Add(pizzaOrder);
            _context.SaveChanges();

        }
    }
}
