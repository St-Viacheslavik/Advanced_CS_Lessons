using System.Collections;

namespace SimpleIndexer
{
    public class PersonCollection : IEnumerable
    {
        private readonly ArrayList _arPeople = new ArrayList();

        // Cast for caller.
        public Person GetPerson(int pos) => (Person)_arPeople[pos];

        public Person this[int index]
        {
            get => (Person) _arPeople[index];
            set => _arPeople.Insert(index, value);
        }


        // Only insert Person types.
        public void AddPerson(Person p)
        { _arPeople.Add(p); }

        public void ClearPeople()
        { _arPeople.Clear(); }

        public int Count => _arPeople.Count;

        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => _arPeople.GetEnumerator();
    }

}
