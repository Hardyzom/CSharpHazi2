using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    static void Main(){
        
        List<string> jarmuvek = new List<string> { "auto", "villamos", "metro" };
        List<string> javitottJarmuvek = jarmuvek.Select(word => word.ToUpper() + "!").ToList();
        Console.WriteLine("1.feladat: " + string.Join(", ", javitottJarmuvek));
  
        List<string> nevek = new List<string> { "aladar", "bela", "cecil" };
        List<string> nagybetusNevek = nevek.Select(nev => char.ToUpper(nev[0]) + nev.Substring(1)).ToList();
        Console.WriteLine("2.feladat: " + string.Join(", ", nagybetusNevek));

        List<int> szamok = Enumerable.Repeat(0, 10).ToList();
        Console.WriteLine("3.feladat: " + string.Join(", ", szamok));

        szamok = Enumerable.Range(1, 10).ToList();
        List<int> megszorzottNumbers = szamok.Select(szam => szam * 2).ToList();
        Console.WriteLine("4.feladat: " + string.Join(", ", megszorzottNumbers));

        List<string> strings = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        szamok = strings.Select(int.Parse).ToList();
        Console.WriteLine("5.feladat: " + string.Join(", ", szamok));

        string szamString = "1234567";
        szamok = szamString.Select(ch => int.Parse(ch.ToString())).ToList();
        Console.WriteLine("6.feladat: " + string.Join(", ", szamok));

        string szoveg = "The quick brown fox jumps over the lazy dog";
        List<int> szoHossz = szoveg.Split(' ').Select(szo => szo.Length).ToList();
        Console.WriteLine("7.feladat: " + string.Join(", ", szoHossz));

        szoveg = "python is an awesome language";
        List<char> kezdobetu = szoveg.Split(' ').Select(szo => szo[0]).ToList();
        Console.WriteLine("8.feladat: " + string.Join(", ", kezdobetu));

        szoveg = "The quick brown fox jumps over the lazy dog";
        List<(string, int)> Tuple = szoveg.Split(' ').Select(szo => (szo, szo.Length)).ToList();
        Console.WriteLine("9.feladat: " + string.Join(", ", Tuple));

        szamok = Enumerable.Range(0, 10).Where(szam => szam % 2 == 0).ToList();
        Console.WriteLine("10.feladat: " + string.Join(", ", szamok));

        szamok = Enumerable.Range(0, 20).Select(szam => szam * szam).Where(szam => szam % 2 == 0).ToList();
        Console.WriteLine("11.feladat: " + string.Join(", ", szamok));

        szamok = Enumerable.Range(0, 20).Select(szam => szam * szam).Where(szam => szam % 10 == 4).ToList();
        Console.WriteLine("12.feladat: " + string.Join(", ", szamok));

        List<char> abc = Enumerable.Range('A', 26).Select(szam => (char)szam).ToList();
        string abcString = string.Join("", abc);
        Console.WriteLine("13.feladat: " + abcString);

        List<string> whitespace = new List<string> { " apple ", " banana ", " kiwi" };
        List<string> whitespaceNelkul = whitespace.Select(szo => szo.Trim()).ToList();
        Console.WriteLine("14.feladat: " + string.Join(", ", whitespaceNelkul));

        List<int> binarisSzam = new List<int> { 1, 0, 1, 1, 0, 1, 0, 0 };
        string binarisString = string.Join("", binarisSzam);
        Console.WriteLine("15.feladat: " + binarisString);
    }
}