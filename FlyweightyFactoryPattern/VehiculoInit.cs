using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightyFactoryPattern
{
    public class VehiculoInit
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Matricula { get; set; }
        public DateTime FechaMatriculacion { get; set; }
        public string NifTitular { get; set; }


        public VehiculoInit(string marca, string modelo, string color, string matricula,
            DateTime fechaMatriculacion, string nifTitular)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.Matricula = matricula;
            this.FechaMatriculacion = fechaMatriculacion;
            this.NifTitular = nifTitular;
        }

        public void MostrarCaracteristicas()
        {
            Console.WriteLine(Marca + " " + Modelo + " de color " + Color +
                " con matricula " + Matricula + " (" + FechaMatriculacion +
                ") registrado por " + NifTitular);
        }
    }
}
