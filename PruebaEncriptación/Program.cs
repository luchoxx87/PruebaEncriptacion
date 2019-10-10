using System;
//El siguiente, es un package NuGet llamado: NETCore.Encrypt
using NETCore.Encrypt;

namespace PruebaEncriptación
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese cadena: ");
            string cadena = Console.ReadLine();
            string sha256 = EncryptProvider.Sha256(cadena);
                        
            Console.WriteLine($"La cadena en formato SHA256 es: \n{sha256}\ny su longitud es {sha256.Length}");
            do
            {
                Console.Write("Reingrese cadena: ");
                //Lee una cadena y la encripta
                cadena = EncryptProvider.Sha256(Console.ReadLine());
                //No se puede salir del bucle, hasta que se coloque la cadena inicial
                //Lo que se compara, son cadenas encriptadas
            } while (sha256!=cadena);
            Console.WriteLine("Contraseña correcta");
        }
    }
}