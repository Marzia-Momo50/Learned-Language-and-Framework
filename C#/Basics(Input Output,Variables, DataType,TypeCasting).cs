using System;

// class test{
//     public static void Main(string[] args)
//     {
//         System.Console.WriteLine("hi");
//     }
// }


//--Variable Naming--//
// class test
// {
//     public static void Main(string[] args)
//     {
//         string name="iphone";
//         double price=321.67;
//         int year=45;

//         Console.WriteLine(name + "\n"+ price + "\n" + year);
//     }
// }


//--TypeCasting--//

// class test{
//     public static void Main(string[] args)
//     {
//         double x=123.33;

//         int y=(int)x;

//         Console.WriteLine(y);

//         double salary=1010.90;

//         //Console.WriteLine(Convert.ToString(salary));

//         int res=Convert.ToInt32(salary);

//         Console.WriteLine($"Number = {res}");

//         //String converted to double//
//         string s="1010.90";
//         bool IsSuccess=double.TryParse(s, out double result);
//         Console.WriteLine($"Result= {IsSuccess} \n result: {result}");
//     }

//     /* implicit>> Automatic Conversion-----> char>int, int>>double
//    explicit>> manually conversion------> 
//    */ 
// }


//--Usr=er Input--//

class test{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Enter The Number: ");
        // string? s=Console.ReadLine();
        // Console.WriteLine(s);

        int age;

        age= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);
    }
}
