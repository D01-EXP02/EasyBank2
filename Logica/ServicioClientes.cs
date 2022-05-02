using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using Datos;
namespace Logica
{
    public class ServicioClientes
    {
        List<Entidades.Cliente> listaClientes;
        public ServicioClientes()
        {
            actualizar();
        }
        public void actualizar()
        {
            //listaClientes = new Datos.RepositorioClientes().Consultar();
            RepositorioClientes reposcliente = new RepositorioClientes();

            listaClientes = reposcliente.Consultar();
        }
        public string Guardar(Cliente cliente)
        {
            string mensaje;
            RepositorioClientes repositorioClientes= new RepositorioClientes();
            mensaje = repositorioClientes.guardar(cliente);
            actualizar();
            return mensaje;
        }
       public Cliente BuscarID(string idCliente, List<Cliente> listaClientes)
        {
            foreach (var item in listaClientes)
            {
                if (idCliente.Equals(item.IdCliente))
                {
                    return item;
                }
            }
            
            return null;
        }
        //Entidades.Cliente Consultar(string idCliente)
        //{
        //    foreach (var item in listaClientes)
        //    {
        //        if (idCliente.Equals(item.IdCliente))
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}
        public List<Cliente> listar()
        {
            actualizar();
            return listaClientes;
        }

    }
}
