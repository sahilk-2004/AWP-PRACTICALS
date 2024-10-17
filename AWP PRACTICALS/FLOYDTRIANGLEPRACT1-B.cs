using System; 
class Program 
{ 
 static void printFloydTriangle(int n) 
 { 
 int i, j, val = 1; 
 for(i=1;i<=n;i++) 
 { 
 for(j=1;j<=i;j++) 
 { 
 Console.Write(val + " "); 
 val++; 
 } 
 Console.WriteLine(); 
 } 
 } 
 public static void Main() 
 { 
 printFloydTriangle(6); 
 } 
}
