namespace lesson6;

class Program
{
    static void Main(string[] args)
    {

        //task1
        //Console.WriteLine("Hello, World!");
        //if (MyTryParse("5", out var result))
        //{
        //    Console.WriteLine(result);
        //}

        //task2
        try
        {
            ProccessNumber(-5);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            if (ex.InnerException != null)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }



    }

    static bool MyTryParse(string myStr, out int num)
    {
        num = 0;
        try
        {
            num = Convert.ToInt32(myStr);

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }
        return true;


    }

    static void ProccessNumber(int number)
    {
        if (number < 0) 
        {
            throw new NegativeNumberException("Num is negative");

        }
        Console.WriteLine(number.ToString());
    }
    
}
