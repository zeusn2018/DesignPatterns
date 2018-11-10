namespace DesignPatterns.Entities.FactoryMethod.WebSite
{
	public class WebsiteFactory
	{

		public static Website GetWebsite(WebsiteType siteType)
		{
			switch (siteType)
			{
				case DesignPatterns.Entities.FactoryMethod.WebSite.WebsiteType.BLOG:
				{
					return new Blog();
				}

				case DesignPatterns.Entities.FactoryMethod.WebSite.WebsiteType.SHOP:
				{
					return new Shop();
				}

				default :
				{
					return null;
				}
			}
		}

	}
}