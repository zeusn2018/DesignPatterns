﻿namespace DesignPatterns.Entities.AbstractFactory.Auto
{
	public interface IAutoFactory
	{
		IAutoMobile CreateSportsCar();
		IAutoMobile CreateLuxuryCar();
		IAutoMobile CreateEconomyCar();
	}
}