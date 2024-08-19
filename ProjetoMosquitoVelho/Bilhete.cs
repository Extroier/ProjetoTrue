using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMosquitoVelho
{
    class Bilhete : Passageiro
    {
        private int id;
        private int numero;
        private string assento;

        
        public void comprar()
        {
            double valordaCompra = 10;
            valordaCompra++;
        }
        public void CancelarReserva()
        {
            //cancela reserva
        }
        public void reservar(Passageiro psg)
        {
            this.assento = psg.Documento;
            //this.id = psg.NumeroCartao;
        }

    }
}
