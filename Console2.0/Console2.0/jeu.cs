using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class jeu
    {

        public jeu()
        {
            // petite presentation du jeu
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("bienvenue sur le jeu dentflash qui te permet de combattre les carries");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("il sensibilise tout le monde a mangé correctement pour éviter de finir sans dent");
            ;

            // creation des classe joueur , carte et carrie muttante;
            CarrieMuttante c = new CarrieMuttante();
            joueur j = new joueur();
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("Hello " + j.nom);
            Carte map = new Carte();

            map.Cart(j, c);


            Console.WriteLine("Vous êtes" + j.nom + ", qui est sur le point de tuer les carrie muttante qui détruisent le royaume");
            Console.WriteLine("Alors que vous vous dirigez dans le repaires vous rencontrez des mutantes");

            Console.WriteLine("premier combat avec le mutante de niveau 1");

            j.choice(c, j);
            Combat.combatcarrie(j, c);
            Console.WriteLine("combat terminer");
            map.trouver2(j, c);

            map.trouver(j, c);

            j.niveau();

            map.Cart(j, c);
            j.choice(c, j);
            Combat.combatcarrie(j, c);
            Console.WriteLine("combat terminer");
            j.niveau();








        }
    }
}
