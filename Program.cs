using System;

namespace sample.studemt
{
    class Program
    {
        static void Main(string[] args)
        {
           int i;
            float avgAll = 0.0f, sum = 0.0f, max = 0.0f;
            string name = "";
            Console.Write("How many students do you have ? ");
            int c = int.Parse(Console.ReadLine());
            string[] names = new string[c];
            float[] avg = new float[c];
            for (i = 0; i < c; i++)
            {
                Console.Write("Enter the name {0} : ", i + 1);
                names[i] = Console.ReadLine();
                Console.Write("Enter avg For {0} :", names[i]);
                avg[i] = float.Parse(Console.ReadLine());
                sum += avg[i];
                if (avg[i] > max)
                {
                    max = avg[i];
                    name = names[i];
                }
            }
            avgAll = sum / c;
            Console.WriteLine("\n Balatar az Miangin Kol : ");
            for (i = 0; i < c; i++)
            {
                if (avg[i] > avgAll) Console.WriteLine(names[i] + " " + avg[i]);
            }
            Console.WriteLine("\nThe best student is {0} {1}\n", name, max);

        }
    }
}
