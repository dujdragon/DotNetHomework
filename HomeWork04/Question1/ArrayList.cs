using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    // 定义一个链表
    class ArrayList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public ArrayList() { head = tail = null; }

        public Node<T> Head { get => head; }
        public void addNode(T d)
        {
            Node<T> n = new Node<T>(d);
            if (tail == null) head = tail = n;
            else
            {
                tail.next = n;
                tail = n;
            }
        }
    }

    // 定义链表节点
    class Node<T>
    {
        public Node<T> next { get; set; }
        public T data { get; set; }
        
        public Node(T d)
        {
            next = null;
            data = d;
        }
    }
}
