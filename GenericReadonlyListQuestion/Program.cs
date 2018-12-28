using System;

namespace GenericReadonlyListQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<object> genericList = new GenericList<object>();
            genericList.Add(new Person() { Firstname = "Mikkes" });
            if (genericList.Get(0) is Person)
            {
                var obj = genericList.Get(0) as Person;
                Console.WriteLine(obj.Firstname);
            }
            else
            {
                Console.WriteLine("the object in the list under the specified index is not a Person type");
            }
            Console.ReadLine();
        }
    }
}
