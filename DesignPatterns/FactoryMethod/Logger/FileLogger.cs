using System;
using System.Diagnostics;

namespace DesignPatterns.Entities.FactoryMethod.Logger
{
	public class FileLogger : ILogger
	{
		public  void Log(string message)
		{
			Debug.WriteLine("File: " + message);
		}
	}

}