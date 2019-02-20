using System;

namespace Week_03
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Guess a number between 1 and 10");
             Random rnd = new Random();

             int num = {1,2,3,4,5,6,7,8,9,10};
             int num1 = rnd.Next(num.Length);
             Console.WriteLine("    num    :{0}", num[num1]);

             Console.WriteLine("Guess a number between 1 and 10");
            if (num > 4){
                Console.WriteLine("Too High!");
            }
            else if (num < 4){
                Console.WriteLine("Too Low");
            }
            else {
                Console.WriteLine("Just Right");
            }
        }
    }
}
