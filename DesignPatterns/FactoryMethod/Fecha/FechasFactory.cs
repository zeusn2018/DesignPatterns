﻿using System;

namespace DesignPatterns.Entities.FactoryMethod.Fecha
{
	public class FechasFactory
	{

		public  FechaGenerica ObtenerFecha()
		{

			ConfiguracionRegional config = ConfiguracionRegional.Instancia;

			if (config.Region.Equals(ConfiguracionRegional.REGION_EEUU, StringComparison.OrdinalIgnoreCase))
			{
				return new FechaEEUU();
			}
			else if (config.Region.Equals(ConfiguracionRegional.REGION_EUR, StringComparison.OrdinalIgnoreCase))
			{
				return new FechaEUR();
			}
			else
			{
				return new FechaLA();
			}
		}
	}
}