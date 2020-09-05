using ConsoleTable;
using System;

namespace Test
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// https://stackoverflow.com/questions/5762491/how-to-print-color-in-console-using-system-out-println
			var table = new Table(3);
			table.AddRow("First Name", "Last Name", "Assessment")
				.AddSeparator();
			Console.Write(table.ToString());
		}
	}
}
