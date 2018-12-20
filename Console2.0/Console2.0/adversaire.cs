using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2._0
{
    class adversaire : joueur
    {
        public int AttaqueEnemie;
        public int vieEnemie;
        public adversaire() : base()
        {
        }

        public int choixAdversaire()
        {
            int ChoixEnemie;
            Random r = new Random();
            ChoixEnemie = r.Next(1, AttaqueEnemie + 1);
            return ChoixEnemie;
        }
    }
}
