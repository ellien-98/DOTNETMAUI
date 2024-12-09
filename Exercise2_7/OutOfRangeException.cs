namespace Exercise2_7
{
    public class OutOfRangeException : Exception
    {
        public OutOfRangeException(string message) : base()
        {   
            Console.WriteLine($"---OutOfRange Exception thrown---");
        }
    }
}
