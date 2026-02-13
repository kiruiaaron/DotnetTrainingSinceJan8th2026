using BlazingPizzaSite.Data;
using static BlazingPizzaSite.Data.Pizza;

namespace BlazingPizzaSite.Services;

public class OrderState
{
    public bool ShowingConfigureDialog { get; set; }
    public Pizza ConfiguringPizza { get; set; }
    public Order Order { get; private set; } = new Order();

    public void ShowConfigurePizzaDialog(PizzaSpecial special)
    {
        ConfiguringPizza = new Pizza()
        {
            Special = special,
            SpecialId = special.Id,
            Size = Pizza.DefaultSize,
            Toppings = new List<PizzaTopping>(),
        };
        ShowingConfigureDialog = true;

    }

    public void cancelConfigurePizzaDialog()
    {
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
    }

    public void confirmConfigurePizzaDialog()
    {
        Order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
    }


}
 public class Order
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.Price * p.Size / 12);
}