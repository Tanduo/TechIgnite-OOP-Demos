namespace CalculatorApp
{
	public class Calculator : BasicMath
	{
		public Calculator()
		{
		}

		public void powerOn()
		{
			Console.WriteLine("Booting up..");
            Thread.Sleep(2000);
            Console.WriteLine();
		
		}
        public void powerDown()
		{
			Console.WriteLine("Shutting down...");
            Thread.Sleep(2000);
		}
    }
}

