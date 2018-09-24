using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderingOps
{
  class Program
  {
    static void Main(string[] args)
    {
      // Order these student names alphabetically, in descending order (Z to A)
      List<string> names = new List<string>()
        {
            "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
            "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
            "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
            "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
            "Francisco", "Tre"
        };

      var descend = from name in names
                    orderby name descending
                    select name;

      foreach (var name in descend)
      {
        Console.WriteLine(name);
      }


      // Build a collection of these numbers sorted in ascending order
      List<int> numbers = new List<int>()
      {
          15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
      };

      var numsAscending = from number in numbers 
                          orderby number ascending
                          select number;

      foreach (var number in numsAscending)
      {
        Console.WriteLine(number);
      }

      Console.Read();
    }
  }
}
