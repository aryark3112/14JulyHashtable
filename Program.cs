using System;
using System.Collections;


namespace _14julyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection!!!");
            //ClassName objectName=new ClassName();
            //objectName.MemberName
            //objectName.PropertyName
            //objectName.MethodName
            ArrayList arrayList = new ArrayList
            {
                "Sam",
                "Ravi",
                "Amit"
            };
            Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Amit");        //to add two more items to existing arrayList
            arrayList.Add("Sunitha");
            Console.WriteLine("After adding two more elements in array list");
            Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("sona");        //to add three more items to existing arrayList
            arrayList.Add("manju");
            arrayList.Add("roy");
            Console.WriteLine("After adding 8 elements in array list");
            Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            arrayList.Add("Raj");         //After adding 1 more item in arrayList
            Console.WriteLine("After adding one more item in array list");
            Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
