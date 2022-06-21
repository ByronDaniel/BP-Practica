//// See https://aka.ms/new-console-template for more information
//using Capacitacion_Bussines_IT.Clases;
//using Capacitacion_Bussines_IT.ClasesAbstractas;
////CuentaBancaria
//Console.WriteLine("CuentaBancaria - Clases, instanciacion y uso de getters setters");
//// nember parameter permite pasar el nombre del parametro y evitar el orden
//CuentaBancaria cuenta1 = new CuentaBancaria(numero: "17513289", saldo: 1000, propietario: "Byron Delgado");

////uso comun 
//CuentaBancaria cuenta2 = new CuentaBancaria("Daniel Peralta", "21213123", 2000);

////Uso de metodos 
//cuenta1.Presentar();
//cuenta2.Presentar();

////uso de getters
//decimal saldoCuenta1 = cuenta1.Saldo; //1000
//Console.WriteLine($"numero de cuenta 1 {saldoCuenta1}");

////uso de setters
//cuenta1.Saldo += 100; //1100
//cuenta1.Presentar();

//Console.WriteLine("-----------------------------------------------------");

////CuentaBancaria2
//Console.WriteLine("CuentaBancaria2 - Clases, instanciacion y uso de getters setters");
//// nember parameter permite pasar el nombre del parametro y evitar el orden
//CuentaBancaria cuenta21 = new CuentaBancaria(numero: "17513289", saldo: 1000, propietario: "Byron Delgado");

////uso comun 
//CuentaBancaria cuenta22 = new CuentaBancaria("Daniel Peralta", "21213123", 2000);

////Uso de metodos 
//cuenta21.Presentar();
//cuenta22.Presentar();

////uso de getters
//decimal saldoCuenta21 = cuenta21.Saldo; //1000
//Console.WriteLine($"numero de cuenta 1 {saldoCuenta1}");

////uso de setters
//cuenta21.Saldo += 100; //1100
//cuenta21.Presentar();

//Console.WriteLine("-----------------------------------------------------");
////CuentaCorriente
//CuentaCorriente cuentaC1 = new CuentaCorriente("Byron Delgado","31342342",200,12);
//cuentaC1.Presentar();

////Cuentas Abstractas 

//CuentaA cuentaA = new CuentaA();
//cuentaA.VerInformacion();


////Arreglos

//Dictionary<string, string> map = new Dictionary<string, string>();

//map.Add("A", "Byron Delgado");
//map.Add("B", "Alejandro");

//foreach(var i in map)
//{
//    Console.WriteLine(i.Value);
//}
async Task<int> Jugar()
{
    for(int i = 0; i< 10; i++)
    {

            await Task.Delay(5000);
        Console.WriteLine(i);
    }
        return i;
}

Console.WriteLine(Jugar());