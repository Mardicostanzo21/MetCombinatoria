using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equazioniLibrary
{
    public class CalcoliCombinatori
    {
        public static long Fattoriale(long numero)
        {
            int risultato = 1;

            if (numero > 20)
            {
                risultato = 0;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    risultato = risultato * i;
                }
            }
            return risultato;
        }






    }
}
