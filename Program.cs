using System;
using System.IO;

namespace Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivo miDocumento = new();

            Console.WriteLine();
            miDocumento.Mensaje();
        }
    }

    class ManejoArchivo
    {
        StreamReader archivo = null;

        int contador;

        string lineas;

        public ManejoArchivo()
        {
            contador = 0;

            //conexión con el archivo.txt
            archivo = new StreamReader(@"C:\Users\HP PROBOOK\OneDrive\Desktop\Manejo de archivo.txt");

            while((lineas = archivo.ReadLine()) != null)
            {
                Console.WriteLine(lineas);
                contador++;
            }
        }

        public void Mensaje()
        {
            Console.WriteLine("Este archivo tiene {0} líneas", contador);
        }


        //creacion del destructor
        ~ManejoArchivo()
        {
            //cerrando conexión con el archivo
            archivo.Close();
        }
    }
}
