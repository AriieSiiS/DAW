using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Funciones
    {
        public static int ContadorLetra(string frase, char letra)
        {
            if (frase.Length == 0)
                return 0;
            else
            {
                if (frase[0] == letra)
                    return 1 +
                else
                    return 0 + ContadorLetra(frase.Remove(0, 1), letra);
                        
            }
            return
        }
    }
}
