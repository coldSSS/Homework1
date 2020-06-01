using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApplication
{

    // 链表节点
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void Foreach(Action<T> action)
        {
            for (Node<T> p = head; p != null; p = p.Next) 
            {
                action(p.Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, max =0, min = int.MaxValue;
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++) 
            {
                list.Add(i);
            }

            list.Foreach(data => { Console.Write(data); });
            Console.WriteLine();
            list.Foreach(data => { max = data > max ? data : max; });
            list.Foreach(data => { min = data < min ? data : min; });
            list.Foreach(data => { sum += data; });
            Console.WriteLine($"max:{max},min:{min},sum:{sum}");

            Console.ReadLine();
        }

    }
}