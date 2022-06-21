using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion_Bussines_IT.Clases
{
    public class CuentaBancaria
    {
        //caracteristicas o atributos 
        private string _propietario;
        private string _numero;
        private decimal _saldo;

        //constructor
        public CuentaBancaria(string propietario, string numero, decimal saldo)
        {
            _propietario = propietario;
            _numero = numero;
            _saldo = saldo;
        }

        //getters and setters
        public string Propietario { get { return _propietario; } set { _propietario = value; } }
        public string Numero { get { return _numero; } set { _numero = value; } }
        public decimal Saldo { get { return _saldo; } set { _saldo = value; } }

        //Metodos
        public void Presentar()
        {
            Console.WriteLine($"Propietario: {Propietario}, numero: {Numero}, saldo: {Saldo}");
        }
    }
}
 