using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        // todo el cliente ?
        private double saldo;
        private double saldoApertura;
        public string IdCuenta { get; set; }
        public string IdCliente { get; set; }
        public double SaldoApertura { get; set; }

        Char Opcion;
        public String crearCuenta()
        {
            
            
                string mensaje = string.Empty;
                Console.WriteLine(" Captura de datos ");
                Console.Write("Id = "); IdCliente = Console.ReadLine();
                Console.Write("Id del cliente = "); IdCliente = Console.ReadLine();
                Console.Write("Saldo de Apertura = "); SaldoApertura = Convert.ToDouble(Console.ReadLine());
                saldo += saldoApertura;

                return " Gracias ";
            
        }


    
       
        
            public string Consignar(double valor)
    {
        saldo += valor;
        return string.Format("se consignaron {0}, tienes un nuevo saldo {1}", valor.ToString(), consultarSaldo().ToString());
    }
    public string Retirar(double valor)
    {
        if (valor == 0)
        {
            return "el valor del retiro no puede ser cero (0) pesos ";
        }

        if (valor > saldo)
        {
            return "fondos insuficientes";
        }
        else
        {
            saldo = saldo - valor;
            return string.Format("se retiraron: {0}, tienes un nuevo saldo: {1}", valor.ToString(), consultarSaldo().ToString());
        }
    }
    public double consultarSaldo()
    {
        return saldo;
    }

    //    public Cuenta(string id, string idcliente, double saldoInicial)
    //{
    //    IdCuenta = id;
    //    IdCliente = idcliente;
    //    saldo = saldoInicial;
    //}

}
}
