using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_5
{
    internal class Mascota
    {
        public String Nombre_Mascota { get; set; }
        public int Edad { get; set; }
        public String Raza { get; set; }
        public char Sexo { get; set; }

        public virtual void Mostrar_Mascota()
        {
            Console.WriteLine("Nombre: "+Nombre_Mascota+" Edad: "+Edad+" Raza: "+Raza+" Sexo: "+Sexo);
        }
    }
}
