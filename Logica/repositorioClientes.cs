using System;
using System.Collections.Generic;
namespace Logica
{
    public class repositorioClientes
    {
        List<Entidades.Cliente> listaClientes = new List<Entidades.Cliente>();
       public string Adicionar(Entidades.Cliente cliente)
        {
            // validar idcliente antes de guardar
            //ServicioClientes servicio = new ServicioClientes();
            if (new ServicioClientes().BuscarID(cliente.IdCliente,listaClientes)==null)
            {
                listaClientes.Add(cliente);
                return string.Format("el cliente {0} ha sido agregado",cliente.NombreCliente);
            }
            return string.Format("el cliente {0} ya existe", cliente.NombreCliente);

        }
        
        string Eliminar()
        {
            return "";
        }

        //string Actualizar(string idCliente, Entidades.Cliente cliente.)
        //{
        //    return "";
        //}
    }
}
