using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class Carte
    {
        // je n'ai pas pu faire la map alors j'ai crée des boucle pour avance et quand ça arrive a termine  il y'a un evenement

        public void Cart(joueur j, CarrieMuttante c)
        {
            Console.WriteLine("commencez avancer");
            Console.WriteLine("vous n'avez qu'une direction possible aller vers la droit en tapons 1");
            Console.WriteLine("tapez touhours sur 1 pour avancer");
            Console.WriteLine(" sur votre chemin vous rencontrerez des creature mutante ou encore ramasserez des bonus");
            int choix = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 3; i++)
            {
                if (choix == 1)
                {
                    int choix1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("vous avancez");
                    Console.WriteLine("vous etes tombez sur un mutant");
                    break;
                   // Combat.combatcarrie(j,c);
                   // Console.ReadLine();
                }
            }

         }

        public void trouver(joueur j, CarrieMuttante c)
        {
            int choix = Convert.ToInt32(Console.ReadLine());
            for (int h = 0; h <= 2; h++)
            {
                if(choix == 1)
                {
                    Console.WriteLine("vous avez trouver un fruits");
                    j.ramasser(j);
                    break;
                }
            }
        }

        public void trouver2(joueur j, CarrieMuttante c)
        {
            int choix = Convert.ToInt32(Console.ReadLine());
            for (int h = 0; h <= 6; h++)
            {
                if (choix == 1)
                {
                    Console.WriteLine("vous avez trouver un legumes");
                    j.ramasser(j);
                    
                    break;
                }
            }
        }

        public void trouver3(joueur j, CarrieMuttante c, arme ar)
        {
            int choix = Convert.ToInt32(Console.ReadLine());
            for (int h = 0; h <= 8; h++)
            {
                if (choix == 1)
                {
                    Console.WriteLine("vous avez trouver une pate ou une brosse");
                    j.objectTrouver = ar.pate;
                    j.objectTrouver = ar.brosse;
                    if (j.objectTrouver == ar.brosse && j.objectTrouver == ar.pate)
                    {
                        j.newAttaque(ar, c, j);
                    }
                    break;
                }
            }
        }
    }
}
