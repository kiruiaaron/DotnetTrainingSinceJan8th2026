using Microsoft.Net.Http.Headers;

namespace BlazingPizzaSite.Data;

public class BlazingPizzaSite
{
    public int PizzaId { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public bool Vegetarian { get; set; }

    public bool Vegan { get; set; }
}