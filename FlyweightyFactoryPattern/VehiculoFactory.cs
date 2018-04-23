using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightyFactoryPattern
{
    public class VehiculoFactory
    {
        // El pool se encargará de almacenar las instancias de los objetos reutilizables
        private static Dictionary<string, ModeloVehiculo> pool = new Dictionary<string, ModeloVehiculo>();

        public static ModeloVehiculo GetCar(string marca, string modelo, string color)
        {
            ModeloVehiculo v = null;

            // Si el modelo ya ha sido creado anteriormente, se recupera del pool
            if (pool.ContainsKey(marca + " " + modelo + " " + color))
            {
                v = pool[marca + " " + modelo + " " + color];
                Console.WriteLine("\t* Recuperando del pool el vehiculo " + marca + " " + modelo + " " + color);
            }

            // En caso de que no exista, se instancia un nuevo objeto y se añade al pool.
            // Las próximas ocasiones en las que el objeto sea utilizado, se devolverá una referencia
            // al objeto existente, evitando ocupar más memoria en crear una nueva instancia
            else
            {
                // Dependiendo de algún parámetro (por ejemplo, si el modelo tiene el sufijo 'sport'), se
                // instanciará una clase u otra.
                if (modelo.EndsWith("sport"))
                    v = new ModeloDeportivo(marca, modelo, color);
                else
                    v = new ModeloBerlina(marca, modelo, color);

                // Se añade el objeto al pool: las sucesivas llamadas usarán este objeto en lugar de
                // instanciar uno nuevo
                pool.Add(marca + " " + modelo + " " + color, v);
                Console.WriteLine("\t* Insertando en el pool el vehiculo " + marca + " " + modelo + " " + color);
            }

            return v;
        }
    }
}
