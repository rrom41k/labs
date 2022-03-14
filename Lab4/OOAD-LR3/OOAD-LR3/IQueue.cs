using System;
using System.Collections.Generic;
using System.Text;

namespace OOAD_LR3
{
    interface IQueue<T>
    {
        T[] queue { get { return queue; } set { queue = value; } } // массив с очередью
        public string ReturnQueue(); // метод для показа текущей очереди
        public void AddItem(T item); // метод добавления нового элемента в очередь 
        public T RemoveItem(); // метод удаления элемента из очереди 

    }
}
