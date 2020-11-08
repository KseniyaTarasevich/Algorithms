using System;
using System.Collections;
using System.Collections.Generic;

namespace ListExample
{
    class ListClass
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5 };

            numbers.Add(6); //  add new element

            numbers.AddRange(new int[] { 7, 8, 9 }); // add array to the list

            numbers.Insert(0, 11); // insert number 11 on the 0 place

            numbers.RemoveAt(1);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<Person> people = new List<Person>(3);

            people.Add(new Person() { Name = "Tom" });
            people.Add(new Person() { Name = "Joe" });

            foreach (Person p in people)
            {
                Console.WriteLine(p.Name);
            }

            ArrayList list = new ArrayList();
            list.Add(2.3);
            list.Add(11);
            list.AddRange(new string[] { "Hello", "world" });

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            list.RemoveAt(0);
            list.Reverse();
            Console.WriteLine(list[0]);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            LinkedList<int> numbers1 = new LinkedList<int>();

            numbers1.AddLast(1);
            numbers1.AddFirst(2);
            numbers1.AddAfter(numbers1.Last, 3);

            foreach (int i in numbers1)
            {
                Console.WriteLine(i);
            }

            LinkedList<Person> persons = new LinkedList<Person>();

            LinkedListNode<Person> john = persons.AddLast(new Person() { Name = "John" });
            persons.AddLast(new Person() { Name = "Jake" });
            persons.AddLast(new Person() { Name = "Alice" });
            persons.AddFirst(new Person() { Name = "Ann" });

            Console.WriteLine(john.Previous.Value.Name);
            Console.WriteLine(john.Next.Value.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
