using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design.Serialization;

namespace PW2
{
    internal class Program
    {
        class TaskSolution
        {
            private double root1;
            private double root2;
            private double a;
            private double b;
            private double c;
            private double D;

            public double SetValueA (double a)
            {
                this.a = NormalizeValueA(a);
                return a;
            }
            public double SetValueB(double b)
            {
                this.b = NormalizeValueB(b);
                return b;
            }
            public double SetValueC(double c)
            {
                this.c = NormalizeValueC(c);
                return c;
            }
            private double NormalizeValueA(double a)
            {
                if (a > 100 ^ a < -100)
                {
                    a = 15;
                }
                return a;
            }
            private double NormalizeValueB(double b)
            {
                if (b > 100 ^ b < -100)
                {
                    b = 15;
                }
                return b;
            }
            private double NormalizeValueC(double c)
            {
                if (c > 100 ^ c < -100)
                {
                    c = 15;
                }
                return c;
            }
            private double Discriminant ()
            {
                D = (b * b) - (4 * a * c);
                return D;
            }
            void CalculateRoots(double root1, double root2)
            {
                Discriminant();
                if (D < 0)
                {
                    this.root1 = 0;
                    this.root2 = 0;
                }
                if (D == 0)
                {
                    this.root1 = ((-b) / (2 * a));
                    this.root2 = 0;
                }
                if (D > 0)
                {     
                    this.root1 = ((-b + Math.Sqrt(D)) / (2 * a));
                    this.root2 = ((-b - Math.Sqrt(D)) / (2 * a));
                }
            }
            private double SetRoot1()
            {
                return this.root1;
            }
            private double SetRoot2()
            {
                return this.root2;
            }

            public void OutputValues ()
            {
                CalculateRoots(root1, root2);
                Console.WriteLine($"Дискриминант равен:{Discriminant()}");
                Console.WriteLine($"Корень первый равен: {SetRoot1()}");
                Console.WriteLine($"Корень второй равен: {SetRoot2()}");
            }

        }
        static void Main(string[] args)
        {
            TaskSolution solution = new TaskSolution();

            Console.WriteLine("Введите значение А");
            solution.SetValueA (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите значение B");
            solution.SetValueB (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите значение C");
            solution.SetValueC (Convert.ToDouble(Console.ReadLine()));
            solution.OutputValues();
        }
    }
}