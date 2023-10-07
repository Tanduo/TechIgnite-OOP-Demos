namespace TestApplication
{
	public class BasicMath
	{
		public BasicMath()
		{
		}
        //Returns the sum of inputs
        public int Add(int input, int input2)
        {
            return input + input2;
        }

        //Returns the product of inputs
        public int Multiply(int input, int input2)
        {
            return input * input2;
        }

        //Returns the input squared
        public int Square(int input)
        {
            return input * input;
        }

        //Returns the square root of the input
        public int SquareRoot(int input)
        {
            return (int)Math.Sqrt(input);
        }

    }
}

