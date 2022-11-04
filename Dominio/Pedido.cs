using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
   public class Pedido
    {
        public int IdPedido { get; set; }

        public int CodProd { get; set; }
        public int IDDepositoDestino { get; set; }

        public int IDDepositoSolicitante { get; set; }
        public int Cantidad { get; set; }

        public DateTime FechaPedido { get; set; }
      
    }
}
