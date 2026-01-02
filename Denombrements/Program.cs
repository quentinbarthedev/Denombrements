using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 0:
                        {
                            { Environment.Exit(0); }
                        }
                        break;
                    case 1:
                        {
                            // saisir le nombre
                            Console.Write("nombre total d'éléments à gérer = ");
                            int nombre = int.Parse(Console.ReadLine());
                            // calcul de r
                            long taille1 = 1;
                            for (int k = 1; k <= nombre; k++)
                            {
                                taille1 *= k;
                            }
                            Console.WriteLine(nombre + "! = " + taille1);
                        }
                        break;
                    case 2:
                        {
                            // saisir le nombre
                            Console.Write("nombre total d'éléments à gérer = ");
                            int total = int.Parse(Console.ReadLine());
                            // saisir le nombre de sous-ensembles
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nombre = int.Parse(Console.ReadLine());
                            // calcul de r
                            long taille2 = 1;
                            for (int k = (total - nombre + 1); k <= total; k++)
                            {
                                taille2 *= k;
                            }
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + total + "/" + nombre + ") = " + taille2);
                        }
                        break;
                    case 3:
                        {
                            // saisir le nombre d'éléments
                            Console.Write("nombre total d'éléments à gérer = ");
                            int total = int.Parse(Console.ReadLine());
                            // saisir le nombre de sous-ensembles
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            int nombre = int.Parse(Console.ReadLine());
                            // calcul de r1
                            long taille2 = 1;
                            for (int k = (total - nombre + 1); k <= total; k++)
                            {
                                taille2 *= k;
                            }
                            // calcul de r2
                            long taille1 = 1;
                            for (int k = 1; k <= nombre; k++)
                            { 
                                taille1 *= k;
                            }
                            // calcul de r3
                            Console.WriteLine("C(" + total + "/" + nombre + ") = " + (taille2 / taille1));
                        }
                        break;
                    default:
                        {
                            do
                            {
                                Console.WriteLine("Erreur: veuillez choisir parmi 0, 1, 2, et 3");
                                Console.WriteLine("Permutation ...................... 1");
                                Console.WriteLine("Arrangement ...................... 2");
                                Console.WriteLine("Combinaison ...................... 3");
                                Console.WriteLine("Quitter .......................... 0");
                                Console.Write("Choix :                            ");
                                choix = int.Parse(Console.ReadLine());
                            } while (choix != 0 && choix != 1 & choix != 2 && choix != 3);

                        }
                        break;
                }               
            }
            Console.ReadLine();
        }
    }
}
