﻿/*void parsujbaze()
{
    string[] strings = new string[2];
    //StreamReader sr = new StreamReader("..\\..\\..\\..\\baza.txt");
    string line = System.IO.File.ReadAllText("..\\..\\..\\..\\baza.txt");
    Console.WriteLine(line);
}

parsujbaze();
*/

void japarsuje()
{
    string scieszka = "..\\..\\..\\..\\baza.txt";
    string login = null;
    string haslo = null;
    using (StreamReader sr = new StreamReader(scieszka))
    {
        login = sr.ReadLine();
        haslo = sr.ReadLine();
    }
    //Console.WriteLine(login);
    //Console.WriteLine(haslo);

    Console.WriteLine("podaj Login i haslo");
    string login2 = Console.ReadLine();
    string haslo2 = Console.ReadLine();

    if (login == login2 && haslo == haslo2)
    {
        Console.WriteLine("gotowy na test trzezwosci? [T/N] :");
    }
    else
    {
        Console.WriteLine("Nie jestes gotowy");
    }

    if (Console.ReadKey().ToString() == "N")
    {
        Console.WriteLine("OK Kys");
        Environment.Exit(0);
    }
    if (Console.ReadKey().ToString() == "T")
    {
        Console.WriteLine("no to cho");
    }
}

japarsuje();