//LINQ//

// class Test{

//    public static void Main(string[] args)
//    {

//        List<int>num= new List<int> {1,21,3,41,5,61,7,81}; 
//        var  even=num.Where(num=> num%2==0);

//        Console.Write($"Count numer of even nums: {even.Count()} \n");
       
//        if(even.Any())
//        {
//           foreach(var item in even)
//        {
//          Console.Write($"{item} ");
//        }

//        }
//        else {
//          Console.WriteLine("Empty");
//        }
      
//    }
// }

// class Student{
//    public string Name{get;set;}
//    public int Score{get;set;}
// }
// class Test{

//    public static void Main(string[] args)
//    {

//       List<Student> students=new List<Student>
//       {
//          new Student {Name="momo",Score=20},
//          new Student {Name="mim",Score=40},
//          new Student {Name="mjj",Score=50},
//       };

//       var LongWord=students.Where(students=>students.Score>20);

//       Console.WriteLine($"Count OF numbers= {LongWord.Count()}");
       
//        if(LongWord.Any())
//        {
//           foreach(var item in LongWord)
//        {
//          Console.Write($"{item.Score}  {item.Name} \n");
//        }

//        }
//        else {
//          Console.WriteLine("Empty");
//        }
      
//    }
// }


//Selct Properties From Object,many operator//


// class Student{
//    public string Name{get;set;}
//    public int Score{get;set;}
//    public int age{get;set;}
// }
// class Test{

//    public static void Main(string[] args)
//    {

//       List<Student> students=new List<Student>
//       {
//          new Student {Name="momo",Score=20,age=8},
//          new Student {Name="mim",Score=40,age=12},
//          new Student {Name="mjj",Score=50,age=87},
//       };
      
//       //var sqr=students.Select(students=>students.Score); for select singel property//
//       var sqr=students.Select(students=>(students.Score ,students.age));

//       //Console.WriteLine($"Count OF numbers= {LongWord.Count()}");
       
//        if(sqr.Any())
//        {
//           foreach(var item in sqr)
//        {
//          Console.Write($"{item.Score}  {item.age} \n");
//        }

//        }
//        else {
//          Console.WriteLine("Empty");
//        }
      
//    }
// }


//Nested List//


using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Score { get; set; }
    public int Age { get; set; }
}

class Test
{
    public static void Main(string[] args)
    {
        List<List<Student>> students = new List<List<Student>>
        {
            new List<Student>
            {
                new Student { Score = 1, Age = 20 },
                new Student { Score = 2, Age = 21 },
                new Student { Score = 3, Age = 22 }
            },
            new List<Student>
            {
                new Student { Score = 1, Age = 25 },
                new Student { Score = 233, Age = 23 }
            },
            new List<Student>
            {
                new Student { Score = 1, Age = 30 },
                new Student { Score = 3, Age = 35 }
            }
        };

        // Select a flattened list of properties
        var sqr = students.SelectMany(group => group.Select(student => new { student.Score, student.Age }));

        if (sqr.Any())
        {
            foreach (var item in sqr)
            {
                Console.WriteLine($"Score: {item.Score}, Age: {item.Age}");
            }
        }
        else
        {
            Console.WriteLine("Empty");
        }
    }
}

