using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_LR3
{
    public class Queue<T> : IQueue<T>
    {
        T[] queue;
        int count = -1; // счётчик для отслеживания заполненности списка(массива)
        public Queue(T[] Queue)
        {
            this.queue = Queue;
            this.count = Queue.Length - 1;
        }
        public Queue()
        {
            this.queue = new T[1];
        }
        public string ReturnQueue()
        {
            if (count >= 0)
            {
                string ret = "\nОчередь: ";
                for (int i = 0; i < count + 1; i++)
                    ret += $"{queue[i]} ";
                return ret;
            }
            else
                return "Список пуст";
        }
        public void AddItem(T item)
        {
            try
            {
                if (count < (queue.Length - 1))
                {
                    for (int i = count; i > 0; i--)
                        queue[i + 1] = queue[i];
                    queue[0] = item;
                    count++;
                }
                else
                {
                    T[] expand = new T[queue.Length + 1];
                    for (int i = 0; i < queue.Length; i++)
                        expand[i + 1] = queue[i];
                    expand[0] = item;
                    queue = expand;
                    count++;
                }
            }
            catch { Console.WriteLine("Не удалось провести операцию по добавлению элемента в очередь"); }
        }
        public T RemoveItem()
        {
            try
            {
                T RemovItem = queue[queue.Length - 1];
                T[] remove = new T[queue.Length - 1];
                for (int i = 0; i < count; i++)
                    remove[i] = queue[i];
                queue = remove;
                count--;
                return RemovItem;
            }
            catch { Console.WriteLine("Не удалось провести операцию по удалению элемента из очереди"); return default(T); }
        }
    }
}
