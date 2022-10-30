namespace RazorPizzaShop.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Sausage { get; set; }
        public bool Mushroom { get; set; }
        public bool CanadianBacon { get; set; }
        public bool Ham { get; set; }
        public bool Beef { get; set; }
        public bool Olives { get; set; }
        public bool GreenPeppers { get; set; }
        public bool Pineapple { get; set; }
        public float FinalPrice { get; set; }
    }
}
