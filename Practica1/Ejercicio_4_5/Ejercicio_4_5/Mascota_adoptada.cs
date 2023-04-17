using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_5
{
    internal class Mascota_adoptada : Mascota
    {
        public String Nombre_Propietario { get; set; }
        public float Pago_Mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }


        public override void Mostrar_Mascota()
    {
        Console.WriteLine("\nNombre: " + Nombre_Mascota + " Edad: " + Edad + " Raza: " + Raza + " Sexo: " + Sexo);
        Console.WriteLine("Nombre Dueño: "+Nombre_Propietario+" Pago Mascota: "+Pago_Mascota+" Fecha Adopcion"+Fecha_Adopcion);
    }

    }
}
