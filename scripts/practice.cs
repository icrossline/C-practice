// 1- WAP to create a calculator using switch statement ?

using System;

public class HelloWorld
{
    public static int Calculator( int choice ,int a ,int b) // method for calculator functionality 
    {
        switch (choice)
        {
            case 1 :
                return a+b;
                break;
            case 2:
                return a-b;
                break;
            case 3:
                return a*b;
                break;
            case 4:
                return a/b;
                break;
            default:
                return 1;
                break;
                
            
        }
    }
    public static void Main(string[] args) // Entry point to a program
    {
      Console.WriteLine("Choose:-\n1-ADD \n2-Subtract \n3-Multiply \n4-Divide");
      int choice = int.Parse(Console.ReadLine());
        
      Console.WriteLine("Enter first number : ");
      int a = int.Parse(Console.ReadLine());
        
      Console.WriteLine("Enter Second number : ");
      int b = int.Parse(Console.ReadLine());
        
      int result=  Calculator(choice , a ,b); // Stored return value in result
         
        if (choice ==1)
        {
            Console.WriteLine("Sum of Two number is " + result);
        }
        else if ( choice ==2)
        {
             Console.WriteLine("Subtraction of Two number is " + result);
        }
         else if ( choice ==3)
        {
             Console.WriteLine("Multiplication of Two number is " + result);
        }
         else if ( choice ==4)
        {
             Console.WriteLine("Division of Two number is " + result);
        }
        else 
        {
            Console.WriteLine("Please Choose a correct Option.");
        }
      
    }
}
