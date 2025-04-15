using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padaria
{
    public class operacoes
    {

        public double Soma(double numero1, double numero2) 
        {
           return numero1 + numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
           return numero1 * numero2;
        }

        public double Divisao(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                return 0;
            }
            else 
            {
                return numero1 / numero2;
            }

           
        }
 
        public double Subtratir(double numero1, double numero2)
        {
         return numero1 - numero2;
        }
    
    }
}
