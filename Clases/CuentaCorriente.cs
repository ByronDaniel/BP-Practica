using Capacitacion_Bussines_IT.ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion_Bussines_IT.Clases
{
    public class CuentaCorriente : CuentaBancaria2
    {
        public CuentaCorriente(string propietario, string numero, decimal saldo, double tasaInteres) : base(propietario, numero, saldo)
        {
            TasaInteres = tasaInteres;
        }

        public double TasaInteres { get; set; }

        public override void Presentar()
        {
            Console.WriteLine($"Propietario: {Propietario}, numero: {Numero}, saldo: {Saldo}, tasa de interes: {TasaInteres}");
        }
    }
}
