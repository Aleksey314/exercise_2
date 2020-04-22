using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffDepartment
{
    class Crew:IList<Worker>
    {
        readonly IList<Worker> workers = new List<Worker>();

        public Worker this[int index] { get => workers[index]; set => workers[index] = value; }

        public int Count => workers.Count;

        public bool IsReadOnly => workers.IsReadOnly;

        public void Add(Worker item)
        {
            workers.Add(item);
        }

        public void Clear()
        {
            workers.Clear();
        }

        public bool Contains(Worker item)
        {
            return workers.Contains(item);
        }

        public void CopyTo(Worker[] array, int arrayIndex)
        {
            workers.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        public int IndexOf(Worker item)
        {
            return workers.IndexOf(item);
        }

        public void Insert(int index, Worker item)
        {
            workers.Insert(index, item);
        }

        public bool Remove(Worker item)
        {
            return workers.Remove(item);
        }

        public void RemoveAt(int index)
        {
            workers.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return workers.GetEnumerator();
        }

        public Crew Sort(Crew w,IComparer<Worker> comparer)
        {
            Worker[] arrayWorker = new Worker[w.Count];
            for(int i = 0; i < w.Count; i++) { arrayWorker[i] = w[i]; }
            Array.Sort(arrayWorker, comparer);
            for (int i = 0; i < w.Count; i++) { w[i] = arrayWorker[i]; }
            return w;
        }        
    }
}
