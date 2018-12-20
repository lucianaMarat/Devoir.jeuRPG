using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class menu
    {

        public menu()
        {
            intro();
            Console.SetCursorPosition(20, 7);
            Console.WriteLine("0-commencez le jeu");
            Console.SetCursorPosition(20, 8);
            Console.WriteLine("1-affichez le meilleur score");
            Console.SetCursorPosition(20, 9);
            Console.WriteLine("2-affichez ");
            Choixmenu();
        }
        public void intro()
        {
            // petite presentation du jeu
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("bienvenue sur le jeu dentflash qui te permet de combattre les carries");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("il sensibilise tout le monde a mangé correctement pour éviter de finir sans dent");
          
        }


        public void Choixmenu()
        {
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("choississez un nombre");
            Console.SetCursorPosition(20, 11);
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    commencerjeu();
                    //Console.WriteLine("le jeu est lancé");
                    break;
                case 2:
                    Console.WriteLine("merci !!! aurevoir");

                    break;

            }
            Console.Clear();
            Console.ReadLine();
        }
        public void commencerjeu()
        {
            jeu j = new jeu();
        }

    }
}
