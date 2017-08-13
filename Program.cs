using System;

namespace _9960471_task01_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3,num4,num5,num6,num7,num8,num9,num10,avg,sum;

            Console.WriteLine("please enter 10 numbers pressing enter after every number and i will calculate for you");
            num1 = int.Parse(Console.ReadLine());
            
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            num5 = int.Parse(Console.ReadLine());
            num6 = int.Parse(Console.ReadLine());
            num7 = int.Parse(Console.ReadLine());
            num8 = int.Parse(Console.ReadLine());
            num9 = int.Parse(Console.ReadLine());
            num10 = int.Parse(Console.ReadLine());
            sum = (num1+num2+num3+num4+num5+num6+num7+num8+num9+num10);
            avg = (sum/5);

            Console.WriteLine("The total sum is"+sum);
            Console.WriteLine("The total avg is"+avg);

            Console.ReadLine();
        }
    }
}
