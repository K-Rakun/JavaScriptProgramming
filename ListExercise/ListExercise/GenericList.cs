using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercise
{
    public class GenericList<T>  where T : IComparable<T>
    {
        private int index;
        private T[] list;

        public GenericList(int initialSize)
        {
            list = new T[initialSize];
            index = 0;
        }



        public void Add(T newItem)
        {
            if (index >= list.Length)
            {
                throw new InvalidOperationException("Shelter is full.");
            }
            list[index] = newItem;
            index++;
        }

        public T GetItem(int i)
        {
            if (i < 0 || i >= index)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: ");
            }
            T chosenItem = list[i];
            for (int n = i; n < index - 1; n++)
            {
                list[n] = list[n + 1];
            }

            list[index - 1] = default;
            index--;
            return chosenItem;
        }

        public void RemoveItem(int i)
        {
            if (i < 0 || i >= index)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: ");
            }
            
            for (int n = i; n < index - 1; n++)
            {
                list[n] = list[n + 1];
            }

            list[index - 1] = default;
            index--;
            
        }

        public void InsertItem(int i,T newItem)
        {
            if (i < 0 || i >= index)
            {
                throw new ArgumentOutOfRangeException(
                "Invalid cell index: ");
            }
            for (int n = index; n > i ; n--)
            {
                list[n + 1] = list[n];
            }
            list[i] = newItem;
            index++;
        }

        public void ClearList()
        {
            for (int n = 0; n < index - 1; n++)
            {
                list[n] = default;
            }
            index = 0;
        }

        public T SearchItem(T searchValue)
        {
            foreach(var Item in list)
            {
                if (Item.CompareTo(searchValue) ==0)
                {
                    return Item;
                }
            }
            return default;
        }

        public void IncreaseCapacity()
        {
            if (index >= list.Length)
            {
                
            }
        }
    }
}
