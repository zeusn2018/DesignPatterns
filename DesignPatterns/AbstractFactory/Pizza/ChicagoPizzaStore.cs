﻿namespace DesignPatterns.Entities.AbstractFactory.Pizza
{
	public class ChicagoPizzaStore : PizzaStore
	{

		protected internal override Pizza CreatePizza(string item)
		{
			Pizza pizza = null;
			PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

			if (item.Equals("cheese"))
			{

				pizza = new CheesePizza(ingredientFactory);
				pizza.Name = "Chicago Style Cheese Pizza";

			}
			else if (item.Equals("veggie"))
			{

				pizza = new VeggiePizza(ingredientFactory);
				pizza.Name = "Chicago Style Veggie Pizza";

			}
			else if (item.Equals("clam"))
			{

				pizza = new ClamPizza(ingredientFactory);
				pizza.Name = "Chicago Style Clam Pizza";

			}
			else if (item.Equals("pepperoni"))
			{

				pizza = new PepperoniPizza(ingredientFactory);
				pizza.Name = "Chicago Style Pepperoni Pizza";

			}
			return pizza;
		}
	}
}