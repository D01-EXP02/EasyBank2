using System;
using System.Collections.Generic;
using System.IO; //0. agregar libreria
using Entidades;
namespace Datos
{
    public class RepositorioClientes
    {
        const string ruta = "clientes.txt";

        public string guardar(Cliente cliente)
        {
            try
            {
                //1. instanciar
                StreamWriter escritor = new StreamWriter(ruta, true);

                //2. operaciones 
                escritor.WriteLine(cliente.ToString()); // idcliente;nombrecliente
                                                     //3. guardar
                escritor.Close();
                return "datos almacenados satisfactoriamente";
            }
            catch (Exception ex) 
            {
                return ex.Message;
                
            }
           
        }
        public Cliente Map(string linea)
        {
            Cliente cliente = new Cliente();

            cliente.IdCliente = linea.Split(';')[0];
            cliente.NombreCliente = linea.Split(';')[1];
            return cliente;
        }
        public List<Cliente> Consultar()
        {
              List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                
                StreamReader lector = new StreamReader(ruta);
                string linea;
                while (!lector.EndOfStream)
                {
                    Cliente cliente = new Cliente();
                    linea = lector.ReadLine();

                    cliente.IdCliente = linea.Split(';')[0];
                    cliente.NombreCliente = linea.Split(';')[1];

                    listaClientes.Add(cliente);
                }
                lector.Close();
                return listaClientes;
            }
            catch (Exception)
            {
                return listaClientes;
            }
           
        }
    }
}
