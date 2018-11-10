using System;
using System.Diagnostics;

namespace DesignPatterns.Entities.FactoryMethod.Pizza
{
	public class ChicagoStyleClamPizza : Pizza
	{
		public ChicagoStyleClamPizza()
		{
			name = "Chicago Style Clam Pizza";
			dough = "Extra Thick Crust Dough";
			sauce = "Plum Tomato Sauce";

			toppings.Add("Shredded Mozzarella Cheese");
			toppings.Add("Frozen Clams from Chesapeake Bay");
		}

		internal override void Cut()
		{
			Debug.WriteLine("Cutting the pizza into square slices");
		}
	}

}