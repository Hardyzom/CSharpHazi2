using System;

class Program{
    static int megforditas(int szam){
        int forditottSzam = 0;
        while (szam > 0){
            forditottSzam = (forditottSzam * 10) + (szam % 10);
            szam /= 10;
        }
        
        return forditottSzam;
    }

    static void Main(){
        int szam = 1977;
        int forditottSzam = megforditas(szam);

        Console.WriteLine("Eredeti: " + szam);
        Console.WriteLine("Fordított: " + forditottSzam);
    }
}
