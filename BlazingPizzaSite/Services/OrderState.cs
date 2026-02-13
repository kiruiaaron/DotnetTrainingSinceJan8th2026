using BlazingPizzaSite.Data;

namespace BlazingPizzaSite.Services;

public class orderstate
{
    public bool ShowingConfigureDialog { get; set; }
    public Pizza ConfiguringPizza { get; set; }
    public Order order { get; private set; } = new Order();

    public void ShowconfigurePizzaDialog(PizzaSpecial special)
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
        order.Pizzas.Add(ConfiguringPizza);
        ConfiguringPizza = null;
        ShowingConfigureDialog = false;
    }
}