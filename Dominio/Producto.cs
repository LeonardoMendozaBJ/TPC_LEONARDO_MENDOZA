using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto
    {
        public int Id { get; set; }
      
        public string Descripcion { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public string ImagenURL { get; set; }

        public int Activo { get; set; }
    }
}
