﻿namespace DesignPatterns.Entities.FactoryMethod.Pizza
{
	public class NYStyleCheesePizza : Pizza
	{

		public NYStyleCheesePizza()
		{
			name = "NY Style Sauce and Cheese Pizza";
			dough = "Thin Crust Dough";
			sauce = "Marinara Sauce";

			toppings.Add("Grated Reggiano Cheese");
		}
	}

}