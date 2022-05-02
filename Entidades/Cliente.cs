using System;

namespace Entidades
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string NombreCliente { get; set; }

        public double SaldoApertura { get;  set; }
        public Cliente(string idCliente, string nombrecliente, double saldoapertura)
        {
            IdCliente = idCliente;
            NombreCliente = nombrecliente;
            SaldoApertura = saldoapertura;
        }
        public Cliente()
        {

        }
        public string datos()
        {
            return IdCliente + ";" + NombreCliente;
        }
        public override string ToString()
        {
            return IdCliente + ";" + NombreCliente;
        }
    }
}
