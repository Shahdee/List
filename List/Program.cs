using System;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> customList = new MyList<int>();

            //customList.Add(0);
            //customList.Add(2);
            //customList.Add(3);

            //foreach (var el in customList) {
            //    Console.WriteLine("el " + el);
            //}

            //customList.Clear();

            //Console.WriteLine(" ---- " + customList.Count);

            //MyList<Animal> animals = new MyList<Animal>();

            //Animal an = null;
            //int count = 10;

            //for (int i = 0; i < count; i++) {
            //    an = new Animal("a"+i);
            //    animals.Add(an);
            //}

            //an = new Animal("a" + 100);
            //animals.Add(an);

            //if (animals.Contains(an)) {
            //    Console.WriteLine("animal list contains " + an.Name);
            //    Console.WriteLine(animals.IndexOf(an));
            //}
            

            //Console.WriteLine(animals[10].Name);

            //animals[10].Name = "delete";

            //Console.WriteLine(animals[10].Name);

            //IEnumerator<Animal> e = animals.GetEnumerator(); 

            //while (e.MoveNext()) {
            //    Console.WriteLine(e.Current.Name);
            //}

            //Console.WriteLine("animals count " + animals.Count + " / "  + animals.IsReadOnly);

            //animals.RemoveAt(0);
            //animals.Remove(an);

            //e = animals.GetEnumerator();

            //while (e.MoveNext())
            //{
            //    Console.WriteLine(e.Current.Name);
            //}

            //animals.Insert(0, an);

            //e = animals.GetEnumerator();

            //Console.WriteLine("----");

            //while (e.MoveNext())
            //{
            //    Console.WriteLine(e.Current.Name);
            //}

            //Animal[] animalArray = new Animal[animals.Count];         

            //animals.CopyTo(animalArray, 0);

            //for (int j = 0; j < animalArray.Length; j++)
            //    Console.WriteLine("array j " + animalArray[j].Name);

            Console.ReadKey();
        }

        class Animal {

            private string m_Type;

            public Animal(string type) {
                m_Type = type;            
            }

            public string Name {

                get { return m_Type; }

                set { m_Type = value; }
            }
        }

        class MyList<T> : IList<T>
        { 
            readonly IList<T> _list = new List<T>();

            public int IndexOf(T item) // +
            {
                return _list.IndexOf(item);
            }

            public void Insert(int index, T item) // +
            {
                _list.Insert(index, item);
            }

            public void RemoveAt(int index) // + 
            {
                _list.RemoveAt(index);
            }

            public T this[int index] // +
            {
                get
                {
                    return _list[index];
                }
                set
                {
                    _list[index] = value;
                }
            }

            public void Add(T item) // +
            {
                _list.Add(item);
            }

            public void Clear() // + 
            {
                _list.Clear();
            }

            public bool Contains(T item) // +
            {
                return _list.Contains(item);
            }

            public void CopyTo(T[] array, int arrayIndex) // +
            {
                _list.CopyTo(array, arrayIndex);
            }

            public int Count // + 
            {
                get { return _list.Count; }
            }

            public bool IsReadOnly // + 
            {
                get { return _list.IsReadOnly; }
            }

            public bool Remove(T item) // + 
            {
                return _list.Remove(item);
            }

            public IEnumerator<T> GetEnumerator() // +
            {
                return _list.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() // + 
            {
                return _list.GetEnumerator();
            }
        }
    }
}
