using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public interface IDataStructures
    {
        int Length
        {
            get;
        }
        int[] ReturnArray();
        int this[int a]
        {
            get;
            set;
        }
        void AddAtTheEnd(int a);
        void AddAtTheEnd(int[] a);
        void AddToTheBeginning(int a);
        void AddToTheBeginning(int[] a);
        void AddByIndex(int a, int b);
        void AddByIndex(int a, int[] b);
        void RemoveFromEnd();
        void RemoveFromEnd(int a);
        void RemoveFromBeginning();
        void RemoveFromBeginning(int a);
        void RemoveByIndex(int a);
        void RemoveByIndex(int a, int b);
        void RemoveByValue(int a);
        int FindIndex(int a);
        int FindMax();
        int FindMin();
        int FindIndexMax();
        int FindIndexMin();
        void ReverseArray();
        void SortInAscending();
        void SortInDescending();
    }
}
