using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Historial
    {
        public int IdPedido { get; set; }

        public int CodProd { get; set; }
        public int IDDepositoDestino { get; set; }

        public int IDDepositoSolicitante { get; set; }
       
        public DateTime FechaHistorial{ get; set; }
    }
}
