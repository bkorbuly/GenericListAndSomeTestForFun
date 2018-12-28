using System;
using System.Collections.Generic;
using System.Text;

namespace GenericReadonlyListQuestion
{
    public class GenericList<T>
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T entity)
        {
            _data.Add(entity);
        }

        public T Get(int index)
        {
            return _data[index];
        }
    }
}
