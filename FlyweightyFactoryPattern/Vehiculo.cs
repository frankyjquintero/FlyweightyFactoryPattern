using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightyFactoryPattern
{
    public class Vehiculo
    {
        // Los datos implícitos estarán encapsulados dentro de la clase ModeloVehiculo
        private ModeloVehiculo datosImplicitos;

        // Datos explícitos
        public string Matricula { get; set; }
        public DateTime FechaMatriculacion { get; set; }
        public string NifTitular { get; set; }

        // Propiedades de acceso a los elementos implícitos.
        // Recordemos que estos datos no deberían variar con el tiempo (son comunes a todas las
        // instancias) y, si lo hicieran, afectarían a todas las instancias.
        public string Marca { get { return datosImplicitos.Marca; } }
        public string Modelo { get { return datosImplicitos.Modelo; } }
        public string Color { get { return datosImplicitos.Color; } }

        // Constructor del vehículo
        // Hace uso de la factoría para obtener (o generar, en caso de que no exista) la parte implícita de
        // los datos del vehículo (marca, modelo y color)
        public Vehiculo(string marca, string modelo, string color,                  // Datos implícitos
            string matricula, DateTime fechaMatriculacion, string nifTitular)       // Datos explícitos
        {
            // Instanciamos o referenciamos los datos implícitos a través de la factoría
            this.datosImplicitos = VehiculoFactory.GetCar(marca, modelo, color);

            // Asignamos los datos propios, exclusivos de este objeto
            this.Matricula = matricula;
            this.FechaMatriculacion = fechaMatriculacion;
            this.NifTitular = nifTitular;
        }

        // Método que accede tanto a datos implícitos como a datos explícitos
        public void MostrarInformacionVehiculo()
        {
            datosImplicitos.MostrarCaracteristicas(" con matricula " + Matricula +
                " (" + FechaMatriculacion.ToShortDateString() +
                ") registrado por " + NifTitular);
        }
    }
}
