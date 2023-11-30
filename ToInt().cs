using System;

static class StringAtalkitas{
    public static int ToInt(this string s){
        return int.Parse(s);
    }
}

class Program{
    static void Main(){
        string s = "42";
        int i = s.ToInt();

        Console.WriteLine(s);   // "42" (string)
        Console.WriteLine(i);   // 42 (int)
    }
}