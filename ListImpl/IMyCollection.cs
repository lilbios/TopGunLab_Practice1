using System;
using System.Collections.Generic;
using System.Text;

namespace ListImpl
{
    public interface IMyCollection<T>: IEnumerable<T>
    {
        void AddToLast(T value);
        void AddToFirst(T value);
        void Add(T value);
        void RemoveFirst();
        void RemoveLast();
        bool Remove(T value);
        T FindByIndex(int index);
        void Clear();
    }
}
