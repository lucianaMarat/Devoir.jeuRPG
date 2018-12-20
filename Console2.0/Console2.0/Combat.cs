using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class Combat
    {
        public static void joueurMeurt(joueur joueur)
        {
            if(joueur.vie <=0 )
            {
                Console.Clear();
                Console.WriteLine("vous avez été tuer");
                Console.WriteLine("game over");
                Console.ReadLine();

            }
        }
        public static void carriemeurt( CarrieMuttante c)
        {
            if (c.vieEnemie <= 0)
            {
                Console.Clear();
                Console.WriteLine("combat remporter avec succes");
                Console.WriteLine("felicitations");
            }
        }
        public void attaquespe(int brosse, int pate, arme ar, joueur j, CarrieMuttante c)
        {
            
            
                if (j.objectTrouver > 0)
                {
                   
                    j.newAttaque(ar, c, j);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("vous ne pouvez pas utiliser les armes car vous n'en avez pas");
                }
            }


        public static void combatcarrie(joueur j, CarrieMuttante c)
        {
          //  while(c.vieEnemie > 0 && j.vie > 0)
           // {
                if (j.vie > 0)
                {
                        // quand il rencontre un mutant il a croit possibilte d'attaque 
                       int choix1 = Convert.ToInt32(Console.ReadLine());

                        if (choix1 == 1)
                        {
                            j.attaquePateDentifrice(c);
                        c.vieEnemie = 0;
                            Console.WriteLine("attaque brosse a dent réussi reussi"); 
                        carriemeurt(c);
                            

                        }
                        if (choix1 == 2)
                        {
                            j.attaqueBrosseDent(c);
                        c.vieEnemie = 0;
                        Console.WriteLine("attaque brosse a dent réussi reussi");
                        carriemeurt(c);
                    }

                        if (choix1 == 3)
                        {
                            j.normAttaque(c);
                       
                            Console.WriteLine("attaque reussi mais la carrie n'est pas mort");
                            j.choice(c, j );
                        }
                    
                    
                    if (choix1 == 5)
                    {
                        j.choice(c, j);
                    }
                    
                }
                if (c.vieEnemie > 0)
                {
                    {
                        c.carrieTour(j);
                        joueurMeurt(j);

                    }

                }

            //}
        }
    }
}
