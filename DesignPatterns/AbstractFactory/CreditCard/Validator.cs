namespace DesignPatterns.Entities.AbstractFactory.CreditCard
{
	public interface Validator
	{
		bool IsValid(CreditCard creditCard);
	}

}