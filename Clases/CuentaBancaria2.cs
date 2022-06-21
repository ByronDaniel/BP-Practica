using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion_Bussines_IT.Clases
{
    public class CuentaBancaria2
    {
        //constructor
        public CuentaBancaria2(string propietario, string numero, decimal saldo)
        {
            Propietario = propietario;
            Numero = numero;
            Saldo = saldo;
        }

        //getters and setters
        public string Propietario { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }

        //Metodos
        public virtual void Presentar()
        {
            Console.WriteLine($"Propietario: {Propietario}, numero: {Numero}, saldo: {Saldo}");
        }
    }
}
 