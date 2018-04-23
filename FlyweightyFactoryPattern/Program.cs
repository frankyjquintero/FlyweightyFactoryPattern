using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightyFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------- Creando Vehiculos ---------------------------");
            Vehiculo v1 = new Vehiculo("Seat", "Ibiza sport", "Amarillo", "1234-CCA", DateTime.Now, "71000011A");
            Vehiculo v2 = new Vehiculo("Seat", "Ibiza sport", "Rojo", "1235-CCA", DateTime.Now, "71000012A");
            Vehiculo v3 = new Vehiculo("Peugeot", "406", "Verde", "1236-CCA", DateTime.Now, "71000013A");
            Vehiculo v4 = new Vehiculo("Renault", "Clio sport", "Amarillo", "1237-CCA", DateTime.Now, "71000014A");
            Vehiculo v5 = new Vehiculo("Seat", "Ibiza sport", "Amarillo", "1238-CCA", DateTime.Now, "71000015A");
            Console.WriteLine("");
            Console.WriteLine("........ Mostrando Datos ........");
            v1.MostrarInformacionVehiculo();
            v2.MostrarInformacionVehiculo();
            v3.MostrarInformacionVehiculo();
            v4.MostrarInformacionVehiculo();
            v5.MostrarInformacionVehiculo();
            Console.ReadKey();
        }
    }
}
