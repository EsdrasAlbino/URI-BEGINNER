using System;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string verteInver = Console.ReadLine();
            string tipo = Console.ReadLine();
            string comid = Console.ReadLine();

            if(verteInver == "vertebrado")
            {
                if (tipo == "ave")
                {
                    if (comid == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (comid == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (tipo == "mamifero")
                {
                    if (comid == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (comid == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (verteInver == "invertebrado")
            {
                if (tipo == "inseto")
                {
                    if (comid == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (comid == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (tipo == "anelideo")
                {
                    if (comid == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (comid == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }

        }
    }
}
