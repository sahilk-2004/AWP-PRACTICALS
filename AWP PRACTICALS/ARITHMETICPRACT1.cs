using System; 
namespace myproject 
{ 
 class Program { 
 static void Main(string[] args) { 
 int a,b,r1,r2,r3,r4; 
 Console.WriteLine("Enter number 1: "); 
 a=Convert.ToInt32(Console.ReadLine()); 
 Console.WriteLine("Enter number 2: "); 
 b=Convert.ToInt32(Console.ReadLine()); 
 r1 = a + b; 
 Console.WriteLine("Addition: "+r1); 
 r2 = a - b;
 Console.WriteLine("Subtraction: "+r2); 
 r3 = a * b; 
 Console.WriteLine("Multiplication: "+r3); 
 r4 = a / b; 
 Console.WriteLine("Division: "+r4); 
 } 
 } 
} 
