using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Transito
    {
        public int IdPedido { get; set; }

        public int IDDepositoDestino { get; set; }

        public int IDDepositoSolicitante { get; set; }

        public DateTime FechaMovimiento { get; set; }

        public int Estado { get; set; }

    }
}
