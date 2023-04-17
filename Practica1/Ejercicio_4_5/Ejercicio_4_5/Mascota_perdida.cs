using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_5
{
    internal class Mascota_perdida : Mascota
    {
        public String Motivo { get; set; }
        public DateTime Fecha_Perdida { get; set; }
        public override void Mostrar_Mascota()
        {
            Console.WriteLine("\nNombre: " + Nombre_Mascota + " Edad: " + Edad + " Raza: " + Raza + " Sexo: " + Sexo);
            Console.WriteLine("Motivo: " + Motivo+ " Fecha Extravio: " + Fecha_Perdida);
            
        }
    }
}
