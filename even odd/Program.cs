using System;

namespace even_odd
{
    class Program
    {
    

        
        static void Main(string[] args)
        {
        string val;
        int res;
        val = Console.ReadLine();
        res = Convert.ToInt32(val);
        bool oddOreven = res % 2 == 0;
        if(oddOreven)
        {
            Console.WriteLine("{0} is even", res);
        }
            else
            {
                Console.WriteLine("{0} is odd", res);
            }
        }
    }
}
