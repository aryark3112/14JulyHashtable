using System;
using System.Collections;


namespace _14julyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Collection!!!");
            //  //ClassName objectName=new ClassName();
            //   //objectName.MemberName
            //   //objectName.PropertyName
            //   //objectName.MethodName
            //ArrayList arrayList = new ArrayList
            //{
            //    "Sam",
            //    "Ravi",
            //    "Amit"
            //};
            //Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Amit");        //to add two more items to existing arrayList
            //arrayList.Add("Sunitha");
            //Console.WriteLine("After adding two more elements in array list");
            //Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("sona");        //to add three more items to existing arrayList
            //arrayList.Add("manju");
            //arrayList.Add("roy");
            //Console.WriteLine("After adding 8 elements in array list");
            //Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Add("Raj");         //After adding 1 more item in arrayList
            //Console.WriteLine("After adding one more item in array list");
            //Console.WriteLine("Number of Element in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is:\t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //arrayList.Sort();
            //Console.WriteLine("*** Sorted Array List ***");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Reverse the List");       // Descending order
            //arrayList.Reverse();
            //Console.WriteLine("*** Sorted Array List in Descending Order ***");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Another Example of Reverve method
            //ArrayList myList = new ArrayList { 12, 24, 30, 11 };
            //Console.WriteLine("Number List");
            //foreach (int i in myList)
            //{ Console.WriteLine(i); }
            //myList.Reverse();
            //Console.WriteLine("***Reverse Number List***");
            //foreach (int i in myList)
            //{ Console.WriteLine(i); }
            //myList.Sort();
            //Console.WriteLine("***Sort Number List***");   //Sort method
            //foreach (int i in myList)
            //{ Console.WriteLine(i); }

            //to remove 
            //ArrayList myList = new ArrayList { 12, 24, 30, 11 };
            //Console.WriteLine("Number List");
            //myList.RemoveAt(3);
            //Console.WriteLine("After Removing from Index 3");
            //foreach (int i in myList)
            //{ Console.WriteLine(i); }
            //myList.Remove(45);
            //Console.WriteLine("After Removing 45");
            //foreach (int i in myList)
            //{ Console.WriteLine(i); }

            ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("Printer");
            hardwareList.Add("Keyboard");
            hardwareList.Add("Mouse");
            hardwareList.Add("Network Card");
            Console.WriteLine("Initial Hardware List");
            for (int i = 0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }
            Console.WriteLine("enter item to search &update");
            string searchItem = Console.ReadLine();
            int index = hardwareList.IndexOf(searchItem);
            if (index == -1)
            { Console.WriteLine($"No such item {searchItem} exist in hardware list"); 
            }
        else
            {
                Console.WriteLine("Enter update item");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("Update Hardware List is as Follows!!!");
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
