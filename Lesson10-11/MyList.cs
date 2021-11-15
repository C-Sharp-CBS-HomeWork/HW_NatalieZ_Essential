using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Lesson10_11
{
    class MyList<T> :  IEnumerable<T>, IEnumerable//, IList, IList<T>//, IReadOnlyCollection<T>, IReadOnlyList<T>,ICollection<T>, ICollection, IList
    {
        private T[] _myList;

        public MyList()
        {
            _myList = new T[0];
        }
        
        public MyList(IEnumerable<T> collection)
        {
            int count = collection.ToArray().Length;
            _myList = new T[count];
            int i = 0;
            foreach (var item in collection)
            {
                _myList[i++] = item;
            }
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            _myList = new T[capacity];
        }

        public int Count => _myList.Length;

        public T this[int index] 
        {
            get 
            {
                if (index < 0 || index >= _myList.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return _myList[index];
            }

            set 
            {
                if (index < 0 || index >= _myList.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _myList[index] = value;
            }
        }

        public void Add(T item)
        {
            T[] temp = new T[Count + 1];
            CopyTo(temp);
            temp[Count] = item;
            _myList = temp;
        }

        public void AddRange(IEnumerable<T> collection) 
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            int count = collection.ToArray().Length;
            T[] temp = new T[Count+count];
            int i = Count;
            _myList.CopyTo(temp, 0);
            foreach (var item in collection)
            {
                temp[i++] = item;
            }
            _myList = temp;
        }

        public void Clear()
        {
            _myList = null;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_myList[i].Equals(item))
                {
                    return true;
                }    
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (array.Length < _myList.Length + arrayIndex)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < Count; i++)
            {
                array[i+arrayIndex] = _myList[i];
            }
        
        }
       
        public void CopyTo(T[] array)
        {
            CopyTo(array, 0);
        }
        
        public void CopyTo(Array array, int arrayindex)
        {
            CopyTo((T[])array, 0);
        }

        public void CopyTo(int index, T[] array, int arrayIndex, int count)
        {
            if (array == null)
            {
                throw new ArgumentNullException();
            }
            if (arrayIndex < 0 || index < 0 || count < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index >= Count || array.Length < arrayIndex + count || Count < index +count)
            {
                throw new ArgumentException();
            }

            for (int i = index, j=arrayIndex; i < index + count; i++, j++)
            {
                array[j] = _myList[i];
            }
        }

        public bool Exists(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(_myList[i]))
                {
                    return true;
                }
            }
            return false;
        }

        [return: MaybeNull]
        public T Find(Predicate<T> match) 
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(_myList[i]))
                {
                    return _myList[i];
                }
            }
            return default;
        }

        public MyList<T> FindAll(Predicate<T> match)
        {
            MyList<T> temp = new MyList<T>();
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (match(_myList[i]))
                {
                    temp.Add(_myList[i]);
                }
            }
            return temp;
        }

        public int FindIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            if (count < 0 || startIndex < 0 && startIndex > _myList.Length - 1 || startIndex + count > _myList.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = startIndex; i < startIndex + count; i++)
            {
                if (match(_myList[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        public int FindIndex(int startIndex, Predicate<T> match)
        {
             return FindIndex(startIndex, Count-startIndex, match);
        }

        public int FindIndex(Predicate<T> match)
        {
            return FindIndex(0, Count, match);
        }

        [return: MaybeNull]
        public T FindLast(Predicate<T> match)
        {
            {
                if (match == null)
                {
                    throw new ArgumentNullException();
                }
                for (int i = Count-1; i >= 0; i--)
                {
                    if (match(_myList[i]))
                    {
                        return _myList[i];

                    }
                }
                return default;
            }
        }

        public int FindLastIndex(int startIndex, int count, Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            if (count < 0 || startIndex < 0 && startIndex > _myList.Length - 1 || startIndex + count > _myList.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = startIndex + count -1; i >= startIndex; i--)
            {
                if (match(_myList[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindLastIndex(int startIndex, Predicate<T> match)
        {
           return FindLastIndex(startIndex, Count-startIndex, match);
        }
        
        public int FindLastIndex(Predicate<T> match)
        {
            return FindLastIndex(0, Count, match);
        }

        public void ForEach(Action<T> action) 
        {
            if (action == null)
            {
                throw new InvalidOperationException();
            }
            for (int i = 0; i < Count; i++)
            {
                action(_myList[i]);
            }
        }

        public MyList<T> GetRange(int index, int count)
        {
            T[] t = new T[count];
            if (count < 0 || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (index + count > _myList.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index, j = 0; i < index + count; i++, j++)
            {
                t[j] = _myList[i];
            }
            return new MyList<T>(t);
        }

        public int IndexOf(T item, int index, int count)
        {
            Predicate<T> predicate = (x) => x.Equals(item);
            return FindIndex(index, count, predicate);
        }
        
        public int IndexOf(T item, int index)
        {
            return IndexOf(item, index, Count-index);
        }

        public int IndexOf(T item)
        {
            return IndexOf(item, 0, Count);
        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            T[] temp = new T[Count + 1];
            int i;
            for (i = 0; i < temp.Length; i++)
            {
                if (i == index)
                {
                    temp[i] = item;
                }
                else if (i < index)
                {
                    temp[i] = _myList[i];
                }
                else 
                {
                     temp[i] = _myList[i-1];              
                }
            }
            _myList = temp;
        }

        public void InsertRange(int index, IEnumerable<T> collection) 
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            int i,j = index;
            int count = collection.ToArray().Length;
            T[] temp = new T[Count + count];
            for (i = 0; i < temp.Length; i++)
            {
                if (i == index)
                {
                    foreach (var item in collection)
                    {
                        temp[i++] = item;
                    }
                    i--;
                }
                else if (i < index)
                {
                    temp[i] = _myList[i];
                }
                else
                {
                    temp[i] = _myList[j++];
                }
            }
            _myList = temp;
        }

        public int LastIndexOf(T item)
        {
            return IndexOf(item, 0, Count);
        }

        public int LastIndexOf(T item, int index)
        {
            return IndexOf(item, index, Count - index);
        }

        public int LastIndexOf(T item, int index, int count)
        {
            Predicate<T> predicate = (x) => x.Equals(item);
            return FindLastIndex(index, count, predicate);
        }

        public bool Remove(T item)
        {
            Predicate<T> predicate = (x) => x.Equals(item);
            int i = FindIndex(predicate);
            if (i == -1)
            {
                return false;
            }
            RemoveAt(i);
            return true;          
        }

        public int RemoveAll(Predicate<T> match)
        {
            int count = 0;
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            int i = FindIndex(match);
            while (i != -1)
            {
                count++;
                RemoveAt(i);
                i = FindIndex(match);
            }
            return count;
        }
        
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            T[] temp = new T[Count - 1];
            for (int i = 0; i < Count; i++)
            {
                if (i < index)
                {
                    temp[i] = _myList[i];
                }
                else if(i > index)
                {
                    temp[i-1] = _myList[i];
                }
            }
            _myList = temp;
        }


        public void RemoveRange(int index, int count)
        {
            if (count < 0 || index < 0 && index > Count - 1 || index + count > Count)
            {
                throw new ArgumentException();
            }
            T[] temp = new T[Count - count];
            int i;
            for (i = 0; i < index; i++)
            {
                temp[i] = _myList[i];
            }
            int j = i;
            for (i = index + count; i < Count; i++, j++)
            {
                temp[j] = _myList[i];
            }
            _myList = temp;
        }

        public void Reverse(int index, int count)
        {
            if (count < 0 || index < 0 && index > Count - 1 || index + count > Count)
            {
                throw new ArgumentException();
            }
            T[] temp = new T[Count];
            int i;
            for (i = 0; i < index; i++)
            {
                temp[i] = _myList[i];
            }
            int j = i;
            // reverse part here
            for (i = index + count-1; i >= index; i--, j++)
            {
                temp[j] = _myList[i];
            }

            for (i = index + count; i < Count; i++)
            {
                temp[i] = _myList[i];
            }

            _myList = temp;

        }

        public void Reverse()
        {
            Reverse(0, Count);
        }

        public T[] ToArray()
        {
            return _myList;
        }

        public bool TrueForAll(Predicate<T> match)
        {
            if (match == null)
            {
                throw new ArgumentNullException();
            }
            for (int i = 0; i < Count; i++)
            {
                if (!match(_myList[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyListEnumerator(_myList);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyListEnumerator(_myList);
        }

        private class MyListEnumerator : IEnumerator<T>, IEnumerator
        {
            T[] _myList;
            int position = -1;

            public MyListEnumerator(T[] myList)
            {
                _myList = myList;
            }

            public T Current {
                get
                {
                    if (position == -1 || position >= _myList.Length)
                        throw new InvalidOperationException();
                    return _myList[position];
                }
            }

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (position < _myList.Length - 1)
                {
                    position++;
                    return true;
                }
                else 
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }
        }

    }
}
