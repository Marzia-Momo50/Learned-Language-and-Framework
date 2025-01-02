//----Exception Handling----//


// public class Myclass
// {
//    public static void Main(string[] args)
//    {
//       try{

//          Console.WriteLine("Enter First Number:");
//          int num1= Convert.ToInt32(Console.ReadLine());

//           Console.WriteLine("Enter second Number:");
//          int num2= Convert.ToInt32(Console.ReadLine());

//          int result=num1/num2;

//          Console.WriteLine($"Result: {result}");

//          if(num1>num2)
//          {
//             throw new ArgumentException("num1 is greter than num2");
//          }
         
//       }

//       catch(OverflowException){
//          Console.WriteLine($"Number is too small or large for int32");
//       }
          
//       catch(Exception e)
//       {
//          //Console.WriteLine($"Erro was occured {e.Message}");
//          Console.WriteLine($"{e}");
//       }  

//       finally
//       {
//          Console.WriteLine("Welcome!!");
//       }  

//       }
//    }



//---IsNull---//

public class Myclass
{
   public static void Main(string[] args)
   {
      try{

         Console.WriteLine("Enter:");
         String s=Console.ReadLine() ?? "";

         int a=Convert.ToInt32(s);
         if(string.IsNullOrEmpty(s))
         {
            throw new ArgumentException("It's Null");
         }

         }

      catch(OverflowException){
         Console.WriteLine($"Number is too small or large for int32");
      }
          
      catch(Exception e)
      {
         //Console.WriteLine($"Erro was occured {e.Message}");
         Console.WriteLine($"{e}");
      }  

      finally
      {
         Console.WriteLine("Welcome!!");
      }  

      }
   }

