using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generatoenumbers
{
    class Program
    {
        public void rep() {
            Console.Write("Почати гру - натисніть 1, завершити та вийти - 2\n");
            
            try
            {
                int p = Convert.ToInt32(Console.ReadLine());

                switch (p)
                {
                    case 1:

                        if (p == 1)
                        {
                            Program s = new Program();
                            s.sus();
                        }
                        break;
                    case 2:
                        if (p == 2)
                        {
                            Environment.Exit(0);
                        }
                        break;
                }


                if (p > 2 || p == 0)
                {
                    Console.Write("Невірне введення, спробуйте заново\n");
                    rep();
                }
            }
            catch (Exception e)
            {
                
                Console.Write("Невірне введення, потрібно ввести число, спробуйте заново\n");
                rep();
            }



        }
        public void sus() {
            Random rnd = new Random();

            Console.Write("Введіть числа від 1 до 3 три рази\n");
            Console.Write("Число 1: ");

            try
            {
                int num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 > 3 || num1 == 0)
                {
                    Console.WriteLine("Не вірне число, спробуйте ще раз\n");
                    sus();
                }

                Console.Write("Число 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num2 > 3 || num2 == 0)
                {
                    Console.WriteLine("Не вірне число, спробуйте ще раз\n");
                    sus();
                }
                Console.Write("Число 3: ");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num3 > 3 || num3 == 0)
                {
                    Console.WriteLine("Не вірне число, спробуйте ще раз\n");
                    sus();
                }
           

            int value = rnd.Next(1, 4);
            int value1 = rnd.Next(1, 4);
            int value2 = rnd.Next(1, 4);
            Console.WriteLine("\n");
            Console.WriteLine("Результат");
            Console.WriteLine($"Ваше число 1: {num1}");
            Console.WriteLine(value);
            Console.WriteLine($"Ваше число 2: {num2}");
            Console.WriteLine(value1);
            Console.WriteLine($"Ваше число 3: {num3}");
            Console.WriteLine(value2);

                if (value == num1)
                {
                    Console.WriteLine("Співпало перше число");
                }

                 if(value1 == num2)
                    {
                    Console.WriteLine("Співпало друге число");
                }
                 if(value2 == num3)
                        {
                    Console.WriteLine("Співпало третє число");
                }

                if (value != num1 && value1 != num2 && value2 != num3)
                {
                    Console.WriteLine("Жодних співпадінь");
                }

                Program s = new Program();
            s.rep();
            }
            catch (Exception e)
            {

                Console.Write("Невірне введення, потрібно ввести число, спробуйте заново\n");
                sus();
            }



        }
        static void Main(string[] args)
        {
            Program s = new Program();
            s.rep();
            Console.Read();



        }
    }
}
