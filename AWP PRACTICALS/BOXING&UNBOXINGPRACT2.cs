using System; 
namespace awd 
{ 
 class Program 
 { 
 static void Main(string[] args) 
 { 
 int num=23; 
 object obj=num; 
 int i=(int)obj; 
 Console.WriteLine("Value of object: "+obj); 
 Console.WriteLine("Value of i: "+i); 
 } 
 } 
} 
