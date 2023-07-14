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
            Console.ReadKey();
        }
    }
}
