using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaEncapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos una instancia de contacto
            Contacto ContactoUno = new Contacto();

            ContactoUno.Nombre = "Sebastian Encinas";
            ContactoUno.Direccion = "Sonora";
            ContactoUno.CorreoElectronico = "sebas_nit_040899@hotmail.com";
            ContactoUno.TelefonoCasa = "4206991";
            ContactoUno.TelefonoCelular = "6442025160";

            Console.WriteLine("Nombre: " + ContactoUno.Nombre);
            Console.WriteLine("Direccion: " + ContactoUno.Direccion);
            Console.WriteLine("Correo electronico: " + ContactoUno.CorreoElectronico);
            Console.WriteLine("Telefono de casa: " + ContactoUno.TelefonoCasa);
            Console.WriteLine("Telefono celular: " + ContactoUno.TelefonoCelular);

            Console.ReadLine();
        }
    }
}
