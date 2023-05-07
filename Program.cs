namespace _20._04_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch = 0;
            do
            {
                Console.WriteLine("enter task num (0-exit)->");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Task1.task1();
                        break;

                    case 2:
                        Task2.task2();
                        break;
                }
            } while (ch!=0);
        }
    }
}