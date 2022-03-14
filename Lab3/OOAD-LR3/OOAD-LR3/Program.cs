using System;

namespace OOAD_LR3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] a = { 4, 3, 2, 1, 0 };
            Queue<int> queue = new Queue<int>(a);
            Console.WriteLine(queue.ReturnQueue()); 
            queue.AddItem(1);
            Console.WriteLine(queue.ReturnQueue());
            queue.AddItem(2);
            Console.WriteLine(queue.ReturnQueue());
            queue.RemoveItem();
            Console.WriteLine(queue.ReturnQueue());
            queue.AddItem(3);
            Console.WriteLine(queue.ReturnQueue());

        }
    }
}
