using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Unidad : Producto    
    {
        int NroSerie { get; set; }

        int IdProd { get; set; }

        int NroDeposito { get; set; }
        
        bool Estado { get; set; }
    }
}
