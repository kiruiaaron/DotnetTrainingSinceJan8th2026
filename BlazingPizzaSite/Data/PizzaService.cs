namespace BlazingPizzaSite.Data;

public class PizzaService

{
    public Task<Pizza[]> GetPizzasAsync()
    {
        return Task.FromResult(new[]
        {
            new Pizza
            {
                PizzaId = 1,
                Name = "Margherita",
                Description = "Tomato sauce, mozzarella, and basil.",
                Price = 8.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 2,
                Name = "Pepperoni",
                Description = "Tomato sauce, mozzarella, and pepperoni.",
                Price = 9.99m,
                Vegetarian = false,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 3,
                Name = "Veggie",
                Description = "Tomato sauce, mozzarella, bell peppers, onions, and olives.",
                Price = 10.99m,
                Vegetarian = true,
                Vegan = false
            },
            new Pizza
            {
                PizzaId = 4,
                Name = "Vegan Delight",
                Description = "Tomato sauce, vegan cheese, mushrooms, and spinach.",
                Price = 11.99m,
                Vegetarian = true,
                Vegan = true
            }
        });
    }
}