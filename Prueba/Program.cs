using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks ;
using Entidades;
using Logica;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("001", "johnp", 200000);
            Cliente cliente2 = new Cliente("002", "juan", 200000);
            Cliente cliente3 = new Cliente("003", "pedro", 200000);

            //repositorioClientes repositorio = new repositorioClientes();
            //Console.WriteLine (repositorio.Adicionar(cliente1));
            //Console.WriteLine(repositorio.Adicionar(cliente2));
            //Console.WriteLine(repositorio.Adicionar(cliente3));
            //Console.WriteLine(repositorio.Adicionar(cliente1));
            Datos.RepositorioClientes repositorioClientes = new Datos.RepositorioClientes();
            Console.WriteLine(repositorioClientes.guardar(cliente1));

            Console.WriteLine(repositorioClientes.guardar(cliente2));

            Console.WriteLine(repositorioClientes.guardar(cliente3));

            List<Cliente> clientes = repositorioClientes.Consultar();
            Console.WriteLine("****************************");

            foreach (var item in clientes)
            {
                Console.WriteLine(item.IdCliente + "-" + item.NombreCliente);
            }
            Console.WriteLine("****************************");
            Console.ReadKey();

        }
    }
}
