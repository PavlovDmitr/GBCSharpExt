namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 4)
            {


                Console.WriteLine(string.Join(" ", args));

            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}