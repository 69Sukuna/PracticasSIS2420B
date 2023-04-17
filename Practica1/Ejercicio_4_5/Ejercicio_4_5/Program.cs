using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota> lmascota = new List<Mascota>();
            //Añadir 10 Mascotas
            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Fido",
                Edad = 2,
                Raza = "Snouzer",
                Sexo = 'M'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Cleto",
                Edad = 1,
                Raza = "Golden",
                Sexo = 'M'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Ladia",
                Edad = 5,
                Raza = "Chiwawa",
                Sexo = 'F'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Beba",
                Edad = 1,
                Raza = "Chiwawa",
                Sexo = 'F'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Garbizu",
                Edad = 4,
                Raza = "Pastor",
                Sexo = 'M'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Nadia",
                Edad = 3,
                Raza = "Husky",
                Sexo = 'F'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Ambrosio",
                Edad = 2,
                Raza = "Chiwawa",
                Sexo = 'M'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Aegon",
                Edad = 2,
                Raza = "Husky",
                Sexo = 'M'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Rawa",
                Edad = 4,
                Raza = "Golden",
                Sexo = 'F'
            });

            lmascota.Add(new Mascota()
            {
                Nombre_Mascota = "Firulais",
                Edad = 2,
                Raza = "Chapi",
                Sexo = 'M'
            });

            //El promedio de la edad de las mascotas con landa
            Prom_Mascota(lmascota);
            //Raza Chiwawa y Femenino con LinQ
            Raza_Chiwawa(lmascota);
            //Edad menor a 2 años
            Edad_Mascota(lmascota);

            Console.ReadKey();
        }

        private static void Edad_Mascota(List<Mascota> listx)
        {
            var perro = from p in listx
                        where p.Edad < 2
                        select p;
            Console.WriteLine("\nEdad Menor a 2 Años");
            foreach (var p in perro)
            {
                Console.WriteLine("Nombre: " + p.Nombre_Mascota + " Edad: " + p.Edad + " Raza: " + p.Raza + " Sexo: " + p.Sexo);
            }
        }

        private static void Raza_Chiwawa(List<Mascota> listx)
        {
            var perro = from p in listx
                        where p.Raza == "Chiwawa" && p.Sexo == 'F'
                        select p;
            Console.WriteLine("\nRAZA CHIWAWA Y FEMENINO");
            foreach (var p in perro)
            {
                Console.WriteLine("Nombre: " + p.Nombre_Mascota + " Edad: " + p.Edad + " Raza: " + p.Raza + " Sexo: " + p.Sexo);
            }
        }

        private static void Prom_Mascota(List<Mascota> listx)
        {
            int pMascota = listx.Sum(x => x.Edad);
            int tMascota = listx.Count();
            double prom = 0;
            prom = Convert.ToDouble(pMascota) / Convert.ToDouble(tMascota);
            Console.WriteLine("El promedio de la edad de las mascotas es: " + prom);
        }
    }
}
