using System;
using System.Linq;

class Program{
    static void Main(){
        int sum = Enumerable.Range(1, 999).Where(szam => szam % 3 == 0 || szam % 5 == 0).Sum();
        
        Console.WriteLine("A szám: " + sum);
    }
}