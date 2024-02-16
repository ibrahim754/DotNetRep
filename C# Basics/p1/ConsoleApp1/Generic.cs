using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /* provide resuablity 
     * provide safty
     * pr
     */
    class Generic
    {
        public static void Print<T>(T obj)
        {
            Console.WriteLine($"Type of the object {typeof(T)}");
            Console.WriteLine($"Value of the obj {obj}");

        }
    }
    public class Any<T>
    {
        private T[] _items;
        public void Add(T item)
        {
            if (_items is null)
            {
                _items = new T[] { item };
            }
            else
            {
                var len = _items.Length;
                T[] items = new T[len + 1];
                for (int i = 0; i < len; i++)
                {
                    items[i] = _items[i];
                }
                items[len] = item;
                _items = items;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _items.Length) return;
            int len = _items.Length;
            T[] items = new T[len - 1];
            for (int i = 0; i < index; i++)
            {
                items[i] = _items[i];
            }
            for (int i = index + 1; i < len ; i++)
            {
                items[i - 1] = _items[i];
            }
            _items = items;
        }
        public void Display()
        {
            Console.Write("{ ");
            foreach (var item in _items)
            {
                Console.Write($", {item}");
            }
            Console.WriteLine(" }");
        }
        public bool isEmpty() => _items.Length == 0 || _items is null;

    }
    public class  AnyClass<T>where T :class, new( )
    {
        // can only use classes
        // new(), the class must have a filedless constructor 
        
    }
}