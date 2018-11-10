using DesignPatterns.Entities.Builder.Ordenacion;

namespace DesignPatterns.Entities.Builder.Ordenacion
{
	public class OrdenacionDirector
	{
		private OrdenacionBuilder builder;

		public OrdenacionDirector(OrdenacionBuilder builder)
		{
			this.builder = builder;
		}

		public virtual void Build(string[] datos)
		{
			builder.Ordenar(datos);
		}
	}

}