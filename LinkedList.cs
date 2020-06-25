using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList : IDataStructures
    {
        private Node root;
        private int length;

        public LinkedList()
        {
            root = null;
            length = 0;
        }

        public LinkedList(int a)
        {
            root = new Node(a);
            length = 1;
        }

        public LinkedList(int[] a)
        {
            if (a.Length != 0)
            {
                root = new Node(a[0]);
                Node tmp = root;
                for (int i = 1; i < a.Length; i++)
                {
                    tmp.Next = new Node(a[i]);
                    tmp = tmp.Next;
                }
                length = a.Length;
            }
            else
            {
                root = null;
                length = 0;
            }           
        }

        public int Length
        {
            get { return length; }
        }

        public int[] ReturnArray()
        {
            int[] array = new int[Length];
            if (Length != 0)
            {
                int i = 0;
                Node tmp = root;
                do
                {
                    array[i] = tmp.Value;
                    i++;
                    tmp = tmp.Next;
                }
                while (tmp != null);
            }
            return array;
        }

        public int this[int a]
        {
            get 
            {
                int c;
                if (a >= length || length == 0 || a < 0)
                {
                    c = 0;
                }
                else
                {
                    Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    c = tmp.Value;
                }
                return c;                
            }
            set 
            {
                if (a >= 0 && a < length && length != 0)
                {
                    Node tmp = root;
                    for (int i = 0; i < a; i++)
                    {
                        tmp = tmp.Next;
                    }
                    tmp.Value = value;
                }                   
            }
        }

        public void AddAtTheEnd(int a)
        {
            if (Length == 0)
            {
                root = new Node(a);
                length = 1;
            }
            else
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    tmp = tmp.Next;
                }
                tmp.Next = new Node(a);
                length++;
            }
        }

        public void AddAtTheEnd(int[] a)
        {
            if (length == 0)
            {
                if (a.Length != 0)
                {
                    root = new Node(a[0]);
                    Node tmp = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    length = a.Length;
                }
                else
                {
                    root = null;
                    length = 0;
                }                
            }
            else
            {
                if (a.Length != 0)
                {
                    Node tmp = root;
                    while (tmp.Next != null)
                    {
                        tmp = tmp.Next;
                    }
                    for (int i = 0; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    length += a.Length;
                }                
            }
        }

        public void AddToTheBeginning(int a)
        {
            Node tmp = new Node(a);
            tmp.Next = root;
            root = tmp;
            length++;
        }

        public void AddToTheBeginning(int[] a)
        {
            if (length == 0)
            {
                if (a.Length != 0)
                {
                    root = new Node(a[0]);
                    Node tmp = root;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    length = a.Length;
                }
                else
                {
                    root = null;
                    length = 0;
                }
            }
            else
            {
                if (a.Length != 0)
                {
                    Node tmp = new Node(a[0]);
                    Node b = root;
                    root = tmp;
                    for (int i = 1; i < a.Length; i++)
                    {
                        tmp.Next = new Node(a[i]);
                        tmp = tmp.Next;
                    }
                    tmp.Next = b;
                    length += a.Length;
                }
            }            
        }

        public void AddByIndex(int index, int a)
        {
            if (index >= 0)
            {
                if (Length < index)
                {
                    AddAtTheEnd(a);
                }
                else
                {
                    if (index == 0)
                    {
                        AddToTheBeginning(a);
                    }
                    else
                    {
                        Node tmp = root;
                        Node b = new Node(a);
                        for (int i = 0; i < index - 1; i++)
                        {
                            tmp = tmp.Next;
                        }
                        Node c = tmp.Next;
                        tmp.Next = b;
                        b.Next = c;
                        length++;
                    }
                }
            }            
        }

        public void AddByIndex(int index, int[] a)
        {
            if (index >= 0)
            {
                if (Length == 0 || index >= Length)
                {
                    AddAtTheEnd(a);
                }
                else
                {
                    if (index == 0)
                    {
                        AddToTheBeginning(a);
                    }
                    else
                    {
                        Node tmp = root;
                        Node b = new Node(a[0]);
                        for (int i = 0; i < index - 1; i++)
                        {
                            tmp = tmp.Next;
                        }
                        Node c = tmp.Next;
                        tmp.Next = b;
                        for (int i = 1; i < a.Length; i++)
                        {
                            b.Next = new Node(a[i]);
                            b = b.Next;
                        }
                        b.Next = c;
                        length += a.Length;
                    }
                }
            }            
        }   

        public void RemoveFromEnd()
        {
            if (Length != 0)
            {
                Node tmp = root;
                Node b = new Node(0);
                while (tmp.Next != null)
                {
                    b = tmp;
                    tmp = tmp.Next;
                }
                tmp = b;
                tmp.Next = null;
                length--;
            }
        }

        public void RemoveFromEnd(int a)
        {
            if (Length != 0)
            {
                if (Length <= a)
                {
                    root = null;
                    length = 0;
                }
                else
                {
                    Node tmp = root;
                    Node b = new Node(0);
                    for (int i = 0; i < Length - a; i++)
                    {
                        b = tmp;
                        tmp = tmp.Next;
                    }
                    tmp = b;
                    tmp.Next = null;
                    length -= a;
                }
            }
        }

        public void RemoveFromBeginning()
        {
            if (Length != 0)
            {
                root = root.Next;
                length--;
            }
        }

        public void RemoveFromBeginning(int a)
        {
            if (Length != 0)
            {
                if (Length <= a)
                {
                    root = null;
                    length = 0;
                }
                else
                {
                    if(a != 0)
                    {
                        Node tmp = root;
                        for (int i = 0; i < a - 1; i++)
                        {
                            tmp = tmp.Next;
                        }
                        root = tmp.Next;
                        length -= a;
                    }                    
                }
            }
        }

        public void RemoveByIndex(int a)
        {
            if (Length != 0 && Length > a && a >= 0)
            {
                if (a != 0)
                {
                    Node tmp = root;                    
                    for (int i = 1; i < a; i++)
                    {                        
                        tmp = tmp.Next;
                    }                    
                    tmp.Next = tmp.Next.Next;                    
                    length--;
                }
                else
                {
                    root = root.Next;
                    length--;
                }
            }
        }

        public void RemoveByIndex(int index, int a)
        {
            if (Length != 0 && Length > index && index >= 0 && a >= 0)
            {
                if (index == 0)
                {
                    RemoveFromBeginning(a);
                }
                else
                {
                    Node tmp = root;                    
                    for (int i = 1; i < index; i++)
                    {                        
                        tmp = tmp.Next;
                    }
                    if (Length > index + a)
                    {
                        Node b = tmp;
                        for (int i = 0; i < a; i++)
                        {
                            b = b.Next;
                        }
                        tmp.Next = b.Next;                        
                        length -= a;
                    }
                    else
                    {
                        tmp.Next = null;
                        length = index;
                    }
                }
            }
        }

        public int FindIndex(int a)
        {
            int index = 0;
            int index1 = 0;
            if (length != 0)
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    if (tmp.Value == a)
                    {
                        index1 = index;
                        break;
                    }
                    else
                    {
                        index++;
                        tmp = tmp.Next;
                    }
                }
            }            
            return index1;
        }

        public void ReverseArray()
        {                        
            Node c = null;
            while (root != null)
            {
                Node tmp = root.Next;
                root.Next = c;
                c = root;
                root = tmp;               
            }
            root = c;
        }

        public int FindMax()
        {
            int max = 0;
            Node tmp = root;
            while (tmp != null)
            {
                if (max < tmp.Value)
                {
                    max = tmp.Value;
                }
                tmp = tmp.Next;
            }            
            return max;
        }

        public int FindMin()
        {
            int min = 0;
            if (root != null)
            {
                min = root.Value;
                Node tmp = root;
                while (tmp != null)
                {
                    if (min > tmp.Value)
                    {
                        min = tmp.Value;
                    }
                    tmp = tmp.Next;
                }
            }            
            return min;            
        }

        public int FindIndexMax()
        {            
            int a = 0;
            if (root != null)
            {
                int index = 0;
                int max = 0;                
                Node tmp = root;
                while (tmp != null)
                {
                    if (max < tmp.Value)
                    {
                        max = tmp.Value;
                        a = index;
                    }
                    tmp = tmp.Next;
                    index++;                    
                }                
            }
            else
            {
                a = -1;
            }
            return a;
        }

        public int FindIndexMin()
        {            
            int a = 0;
            if (root != null)
            {
                int index = 0;
                int min = root.Value;                
                Node tmp = root;
                while (tmp != null)
                {
                    if (min > tmp.Value)
                    {
                        min = tmp.Value;
                        a = index;
                    }
                    tmp = tmp.Next;
                    index++;
                }                
            }
            else
            {
                a = -1;
            }
            return a;
        }

        public void SortInAscending()
        {
            if (Length != 0)
            {
                Node tmp = root;
                int l = 0;
                while (tmp.Next != null)
                {
                    if (tmp.Value > tmp.Next.Value)
                    {
                        int a = tmp.Next.Value;
                        tmp.Next.Value = tmp.Value;
                        tmp.Value = a;
                        l = 1;
                    }
                    tmp = tmp.Next;
                }
                if (l != 0)
                {
                    SortInAscending();
                }
            }            
        }

        public void SortInDescending()
        {
            if (Length != 0)
            {
                Node tmp = root;
                while (tmp.Next != null)
                {
                    if (tmp.Value < tmp.Next.Value)
                    {
                        int a = tmp.Next.Value;
                        tmp.Next.Value = tmp.Value;
                        tmp.Value = a;
                        SortInDescending();
                    }
                    else
                    {
                        tmp = tmp.Next;
                    }
                }
            }            
        }

        public void RemoveByValue(int a)
        {
            if (Length != 0)
            {
                while (root.Value == a && Length > 1)
                {
                    root = root.Next;
                    length--;
                }
                if (Length == 1 && root.Value == a)
                {
                    root = null;
                    length = 0;                    
                }
                else
                {
                    Node tmp = root;
                    int b = Length;
                    for (int i = 1; i < b; i++)
                    {                        
                        if (tmp.Next.Value == a)
                        {
                            tmp.Next = tmp.Next.Next;                            
                            length--;
                        }
                        else
                        {
                            tmp = tmp.Next;
                        }                        
                    }
                }                
            }           
        }
    }     
}
