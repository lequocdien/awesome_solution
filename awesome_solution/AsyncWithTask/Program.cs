using System;
using System.Threading.Tasks;

namespace AsyncWithTask
{
    class Program
    {
        public delegate void NotifyHandler(string msg);
        public static event NotifyHandler NotifyEvent;

        public static async Task<long> DoSomething1()
        {
            Console.WriteLine("Task 1 bat dau");
            Task<long> task = new Task<long>(() =>
            {
                long sum = 0;
                for (int i = 0; i < 1000; i++)
                {
                    sum = sum + i;
                }
                return sum;
            });
            task.Start();
            await task;
            NotifyEvent("Task 1 da xong");
            return task.Result;
        }

        static void Main(string[] args)
        {
            Task task = DoSomething1();
            bool status = false;
            NotifyEvent += (string msg) => { Console.WriteLine(msg); status = true; };
            for (int i = 0; i < 10000; i++)
            {
                if (status == true)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
