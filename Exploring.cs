using System.Collections.Generic;

public class Exploring {
   	public static void Main() {

   		List<int> integers = new List<int>();
   		integers.Add(1);
   		integers.Add(3);
   		integers.Add(5);

   		int first = integers[0];
   		int last = integers[integers.Count-1];
   		int numCount = integers.Count;

      	System.Console.WriteLine("First list value:  " + first);
      	System.Console.WriteLine("Last list value: " + last);
      	System.Console.WriteLine("Number in list: " + numCount);
   	}
}