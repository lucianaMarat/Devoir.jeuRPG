using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class joueur
    {

        public string nom;
      //  public enum genre { fille, garcon };
        public int attaque;
        public int vie;
        public int nivo = 7;
        public int  maxvie= 15;
      
        private int force;
        public int objectTrouver;
        

        public joueur()
        {
           // aquipements au commencements
            attaque = 0;
            vie = 3;
            force = 5;
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("entre ton nom");
            Console.SetCursorPosition(50, 12);
            nom = Console.ReadLine();
            //Console.WriteLine("donne ton genre");
           
            
            Console.Clear();
            Console.SetCursorPosition(20, 8);
            presentation();

        }
        public void presentation()
        {// montre au joueur qu'est ce qu'il possède au debut
            Console.WriteLine("votre nom:  "+ nom+ "  point d'attaque  " + attaque+ "  point de vie:   " + vie);
        }
        public void normAttaque(joueur j)
        {
            j.vie -= attaque; // attaque normal
           
        }
        public void niveau()
        {
           
                Console.WriteLine(" vous avez atteint un nouveau niveau");

                attaque += 3;
                maxvie += 10;
                vie = maxvie;
                nivo += 5;
            

        }

        public void soin()
        {
            vie += nivo;
            if(vie > maxvie)
            {
                vie = maxvie;
            }
        }
        public void ramasser( joueur j)   // quand le joueur trouve des fruits ou des legumes il gagne en force
        {
            int fruits = 1;
            int legumes = 2;     
            j.force += fruits + 1;
            Console.WriteLine("vous avez ramassez : "+ fruits);
            j.force += legumes * 2;
            Console.WriteLine("vous avez ramassez :" + legumes);
            if (force == 10)
            {
                niveau();  // si sa force dépasse 10 il passe en niveau
            }
        }

        public void newAttaque(arme ar, CarrieMuttante c, joueur j)
        {
            if (j.objectTrouver == ar.brosse && j.objectTrouver ==  ar.pate)
            {
                c.vieEnemie -= attaque = 0;
            }
        }

        public void attaquePateDentifrice(adversaire a)
        {
            a.vieEnemie -= (attaque - 10); // attaque qui tue la carrie

        }
        public void attaqueBrosseDent( adversaire a)
        { 
             a.vieEnemie -= attaque * 2; // attaque qui tue
        }

        public void choice(CarrieMuttante c, joueur j) // menu de posibilité de choix
        {

          //  while (true)
          //  {
                Console.WriteLine("choisssez ce dont vous avez besoin");
                Console.WriteLine("1.Attaque");
                Console.WriteLine("2.soin");


                int choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("1.attaque pate dentifrice");
                    Console.WriteLine("2.attaque brosse a dent");
                    Console.WriteLine("3.attaque normal");
                    Console.WriteLine("4. attaque fatal");
                    Console.WriteLine("5.revenir au premier menu");

                    Combat.combatcarrie(j, c);
                }
                if (choix == 2)
                {
                    soin();
                    Console.WriteLine("vous avez reçu des soins");
                }
            
            
        }
       



        

    }
   
}
