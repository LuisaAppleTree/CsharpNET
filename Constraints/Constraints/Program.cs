using System;
using System.Collections.Generic;

namespace Constraints
{

    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            return Age.CompareTo(other.Age);
        }
    }

    public interface IComparable<T>
    {
        int CompareTo(T other);
    }

    public class ComparableList<T> where T : IComparable<T>
    {
        public bool IsSorted(List<T> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(list[i - 1]) < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ComparableList<Person> personList = new ComparableList<Person>();

            List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 29 },
            new Person { Name = "Mary", Age = 12 },
            new Person { Name = "Peter", Age = 67 }
        };

            Console.WriteLine("¿Está ordenada la lista de personas? " + personList.IsSorted(people));
            Console.ReadLine();
        }
    }

}
