using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DepositoNegocio
    {
        public List<Deposito> listar()
        {
            List<Deposito> lista = new List<Deposito>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(" select IDDEPOSITO, NOMBRE, DIRECCION , TELEFONO , CP from DEPOSITO ");
                datos.ejecutarLecura();
                while (datos.Lector.Read())
                {
                    Deposito aux = new Deposito();
                    aux.IdDeposito = (int)datos.Lector["IDDEPOSITO"];
                    
                    if (!(datos.Lector["NOMBRE"] is DBNull))
                        aux.Nombre = (string)datos.Lector["NOMBRE"];

                    if (!(datos.Lector["DIRECCION"] is DBNull))
                        aux.Direccion = (string)datos.Lector["DIRECCION"];

                 
                    if (!(datos.Lector["TELEFONO"] is DBNull))
                        aux.Telefono = (string)datos.Lector["TELEFONO"];

                    if (!(datos.Lector["CP"] is DBNull))
                        aux.CP = (int)datos.Lector["CP"];
                   
                    lista.Add(aux);

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
