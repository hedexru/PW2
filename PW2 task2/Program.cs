namespace PW2_task2
{
    internal class Program
    {
        class TaskSolution
        {
            private int n = 0;
            public bool setNumber (int num)
            {
                if (n + 1 == num) {
                this.n = num;
                return true;
            }
            else
            {
               this.n = 0;
               return false;
            }
            }
            public void returnExpectedResult ()
            {
                Console.WriteLine(n+1);
            }
        }
        static void Main(string[] args)
        { 
            TaskSolution HEDEX = new TaskSolution();
            int n = 0;
            while (true)
            {
                Console.Write("Введите число:");
                HEDEX.returnExpectedResult();
                Console.WriteLine(HEDEX.setNumber(int.Parse(Console.ReadLine())));
            }
        }
    }
}