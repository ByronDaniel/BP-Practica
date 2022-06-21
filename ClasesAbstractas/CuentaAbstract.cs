using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capacitacion_Bussines_IT.ClasesAbstractas
{
    public abstract class CuentaAbstract
    {
        public abstract void EstablecerSaldo(decimal valor);
        public abstract string ObtenerNumero();
        public void VerInformacion()
        {
            Console.WriteLine("Informacion de mi cuenta");
        }
    }
}
