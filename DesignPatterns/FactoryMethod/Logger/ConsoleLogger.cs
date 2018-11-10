using System;
using System.Diagnostics;

namespace DesignPatterns.Entities.FactoryMethod.Logger
{
	public class ConsoleLogger : ILogger
	{
		public  void Log(string message)
		{
			Debug.WriteLine("Console: " + message);
		}
	}

}