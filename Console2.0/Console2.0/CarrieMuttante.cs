using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class CarrieMuttante : adversaire
    {
        public CarrieMuttante() : base()
        {
            AttaqueEnemie = 2;
            vieEnemie = 2;
        }

        public void carrie(joueur j)
        {
            j.vie -= attaque - 2; // a chaque fois que le joueur est toucher par le muttant il pert 2 point
        }
       
        public void carrieTour (joueur j)
        {
            int choix2 = Convert.ToInt32(Console.ReadLine());
            if(choix2 == 1)
            {
                normAttaque(j);
                Console.WriteLine("la carrie t'a touché"); // attaque normal
            }
            if(choix2 == 2)
            {
                carrie(j);    // attaque special muttant
                Console.WriteLine("vous avez été tuer");
            }
            Console.ReadLine();
            Console.Clear();

        }

       
    }
}
