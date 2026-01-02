using System;

namespace Denombrements
{
    class Program
    {
        static void menu(ref int choix)
        {
            Console.WriteLine();
            Console.WriteLine("Permutation ...................... 1");
            Console.WriteLine("Arrangement ...................... 2");
            Console.WriteLine("Combinaison ...................... 3");
            Console.WriteLine("Quitter .......................... 0");
            Console.Write("Choix :                            ");
            choix = int.Parse(Console.ReadLine());
        }
        static long saisie1(int n, long r2)
        {
            for (int k = 1; k <= n; k++)
            {
                r2 *= k;
            }
            return r2;
        }
        static long saisie2(string message1, string message2, ref int t, ref int n, long r1)
        {
            Console.Write(message1 + " = ");
            t = int.Parse(Console.ReadLine());
            Console.Write(message2 + " = ");
            n = int.Parse(Console.ReadLine());
            // calcul de r1
            r1 = 1;
            for (int k = (t - n + 1); k <= t; k++)
            {
                r1 *= k;
            }
            return r1;
        }
        static void Main(string[] args)
        {
            int n = 0, t = 0, choix = 1;
            long r1 = 1, r2 = 1;
            while (choix != 0)
            {
                menu(ref choix);
                // Choix possibles
                switch (choix)
                {
                    case 0:
                        {
                            { Environment.Exit(0); }
                        }
                        break;
                    case 1:
                        {
                            // saisie du nombre d'éléments à gérer
                            Console.Write("nombre total d'éléments à gérer = ");
                            n = int.Parse(Console.ReadLine());
                            // calcul de r2
                            r2 = saisie1(n, 1);
                            // Affichage
                            Console.WriteLine(n + "! = " + r2);
                        }
                        break;
                    case 2:
                        {
                            // saisie du nombre d'éléments et sous ensembles à gérer
                            r1 = saisie2("nombre total d'éléments à gérer", "nombre d'éléments dans le sous ensemble ", ref t, ref n, r1);                         
                            // Affichage
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r1);
                        }
                        break;
                    case 3:
                        {
                            // saisie du nombre d'éléments et sous ensembles à gérer
                            r1 = saisie2("nombre total d'éléments à gérer", "nombre d'éléments dans le sous ensemble ", ref t, ref n, r1);
                            // calcul de r2
                            r2 = saisie1(n, 1);
                            // Calcul de r3 et affichage
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                        }
                        break;
                    default:
                        {                         
                            Console.WriteLine("Erreur : choisissez entre 0, 1, 2, ou 3");                         
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}