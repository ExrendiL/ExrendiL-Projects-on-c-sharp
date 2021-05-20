using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masivi
{
    class Program

    {
        public void op() {
            try
            {
                int[] nums = new int[4];

                Console.WriteLine("Enter number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 3");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 4");
                int num4 = Convert.ToInt32(Console.ReadLine());

                nums[0] = num1;
                nums[1] = num2;
                nums[2] = num3;
                nums[3] = num4;
                // Console.WriteLine("Result of sorting into negative and positive numbers");
                Console.WriteLine("Array");
                foreach (int number in nums)
                {
                    Console.WriteLine(number);
                }
                int result = 0;
                foreach (int number in nums)
                {
                    if (number > 0)
                    {
                        result++;
                    }
                }
                Console.WriteLine($"Positive numbers: {result}");
                int result1 = 0;
                foreach (int number in nums)
                {
                    if (number <= 0)
                    {
                        result1++;
                    }
                }
                Console.WriteLine($"Negative numbers: {result1}");
                Program r = new Program();
                r.rep();
            }
            catch (Exception e) {
                Console.WriteLine("Not correct entered data, please try again");
                op();

            }

        }

        public void rep() {
            Console.WriteLine("Enter 1 - start, enter 2 - end prog");
            try
            {
                int w = Convert.ToInt32(Console.ReadLine());

                switch (w)
                {
                    case 1:
                        Program r = new Program();
                        r.op();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                }
                if (w<=0 || w>2) {
                    Console.WriteLine("Not correct entered data, please try again");
                    rep();

                }
            }
            catch (Exception e) {
                Console.WriteLine("Not correct entered data, please try again");
                rep();
            }

        }
        static void Main(string[] args)
        {
            //  int[] wo = {1,55,3};
            // String[] we = {"loszhka","wierd"};
            /* foreach (int i in wo)
             {
                 Console.WriteLine(i);


             }*/

            // Console.WriteLine("\n");
            /* foreach (String a in we)
             {
                 Console.WriteLine(a);
             }
             Console.WriteLine("\n");
             Console.WriteLine("Type of array\n"+wo +"\n"+we + "\n");*/

            Program r = new Program();
            r.rep();


            Console.Read();
        }
    }
}
