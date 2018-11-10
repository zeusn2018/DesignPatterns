using System.Collections.Generic;

namespace DesignPatterns.Entities.Builder.Ordenacion
{

	public abstract class OrdenacionBuilder
	{
		public abstract List<string> Ordenar(string[] datos);
	}

}