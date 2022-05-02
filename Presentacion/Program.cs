using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {

           //Entidades.Cliente cliente = new Entidades.Cliente();
            Entidades.Cuenta cuenta = new Entidades.Cuenta();
            int Opcion;
            bool aux = true;
            char Opcion2;
            double valor, Retiro;
            Console.WriteLine(" **************** MENU ****************");
            Console.WriteLine("\n 1.) Crear Cuenta Clientes");
            Console.WriteLine(" 2.) Consignar ");
            Console.WriteLine(" 3.) Retirar ");
            Console.WriteLine(" 4.) Consultar Saldo ");
            Console.WriteLine(" 5.) SALIR ");
            Console.WriteLine("Digite la opcion que desea: ");Opcion = Convert.ToInt32(Console.ReadLine());
            
            do
            {


                switch (Opcion)
                {
                    case 1:
                        
                        do
                        {
                          Console.WriteLine(cuenta.crearCuenta());
                          Console.WriteLine(" \n Quiere Crear Otra cuenta? [S/N]");
                          Opcion2 = Convert.ToChar(Console.ReadLine());
                            if (Opcion2 == 'S')
                            {
                                aux = true;
                            }
                            else
                            {
                                aux = false;
                            }
                        } while (aux == true);
                        
                        break;
                    case 2:                   
                        Console.WriteLine("Ingrese el Valor a Consignar: "); valor = Convert.ToDouble(Console.ReadLine());
                        cuenta.Consignar(valor);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el valor a retirar: "); Retiro = Convert.ToDouble(Console.ReadLine());
                        cuenta.Retirar(Retiro);
                        break;
                    case 4:
                        cuenta.consultarSaldo();
                        break;
              
                    default:
                        Console.WriteLine(" ERROR Favor ingresar un numero valido :D ");
                        break;
                }

            }while(5!=Opcion);

            Console.ReadKey();
        }
    }
}
