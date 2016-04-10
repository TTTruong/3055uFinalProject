using System;
using System.Collections.Generic;

public class Exploring {

   public static List<int> loadIntegers(List<int> integerList) {
      integerList.Add(1);
      integerList.Add(3);
      integerList.Add(5);

      return integerList;
   }

   // Special for C# : LINQ's and delegates.

   public static void Main() {

      List<int> integers = new List<int>();

      integers = loadIntegers(integers);
   	int first = integers[0];
   	int last = integers[integers.Count-1];
   	int numCount = integers.Count;

      Console.WriteLine("First list value:  " + first);
      Console.WriteLine("Last list value: " + last);
      Console.WriteLine("Number in list: " + numCount);
   }
}