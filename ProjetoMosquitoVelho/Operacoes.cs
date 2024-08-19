using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Operacoes
    {
        //método construtor
        public Operacoes()
        {
            //pode se colocar parametros
        }
        public static double somar(double valor1, double valor2)
        { 
        return (valor1+ valor2);
        }
        public double menos(double valor1, double valor2)
        {
            return (valor1 - valor2);
        }
        public double vezes(double valor1,double valor2)
        {
            return (valor1 * valor2);
        }
        public double dividir(double valor1, double valor2)
        {
            //else
            if (valor2 !=0)
            {
                return (valor1 / valor2);
            }
            else
            {
                return 0;
            }
            
        }
        public double potencia(double valor1, double valor2)
        {
            //loop
            return Math.Pow(valor1, valor2);
        }
    }
}
