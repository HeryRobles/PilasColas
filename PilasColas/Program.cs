using Arreglos;
using Listas;
//using System;

Console.WriteLine("--------Arreglos Pilas--------");

Arreglos.Pilas pilas = new Arreglos.Pilas(5);
pilas.Agregar("cero");
pilas.Agregar("Uno");
pilas.Agregar("Dos");
pilas.Agregar("Tres");
pilas.Agregar("Cuatro");

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("----------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("--------Arreglos Colas--------");

Arreglos.Colas colas = new Arreglos.Colas(5);
colas.Agregar("cero");
colas.Agregar("Uno");
colas.Agregar("Dos");
colas.Agregar("Tres");
colas.Agregar("Cuatro");

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("----------------------");
        colas.Eliminar();
        Console.WriteLine(colas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("--------Listas Pilas--------");

Listas.Pilas Pilas = new Listas.Pilas();

Pilas.Agregar("Cero");
Pilas.Agregar("Uno");
Pilas.Agregar("Dos");
Pilas.Agregar("Tres");
Pilas.Agregar("Cuatro");

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("--------------------");
        Pilas.Eliminar();
        Console.WriteLine(Pilas.Imprimmir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine("--------Listas Colas--------");

Listas.Colas Colas = new Listas.Colas();

Colas.Agregar("Cero");
Colas.Agregar("Uno");
Colas.Agregar("Dos");
Colas.Agregar("Tres");
Colas.Agregar("Cuatro");

for (int i = 0; i < 5; i++)
{
    try
    {
        Console.WriteLine("--------------------");
        Colas.Eliminar();
        Console.WriteLine(Colas.Imprimir());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}






//namespace PilasColas
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ListasPilas();
//            ListasColas();
//        }
//        static void ArregloPilas()
//        {
//            try
//            {
//                Arreglos.Pilas ArrayPilas = new Arreglos.Pilas(5);
//                ArrayPilas.Agregar("cero");
//                ArrayPilas.Agregar("Uno");
//                ArrayPilas.Agregar("Dos");
//                ArrayPilas.Agregar("Tres");
//                ArrayPilas.Agregar("Cuatro");
//                Console.WriteLine(ArrayPilas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayPilas.Eliminar();
//                Console.WriteLine(ArrayPilas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayPilas.Eliminar();
//                Console.WriteLine(ArrayPilas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayPilas.Eliminar();
//                Console.WriteLine(ArrayPilas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayPilas.Eliminar();
//                Console.WriteLine(ArrayPilas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayPilas.Eliminar();
//                Console.WriteLine(ArrayPilas.Imprimir());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }

//        }
//        static void ArreglosColas()
//        {
//            try
//            {
//                Arreglos.Colas ArrayColas = new Arreglos.Colas(5);
//                ArrayColas.Agregar("Cero");
//                ArrayColas.Agregar("Uno");
//                ArrayColas.Agregar("Dos");
//                ArrayColas.Agregar("Tres");
//                ArrayColas.Agregar("Cuatro");
//                Console.WriteLine(ArrayColas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayColas.Eliminar();
//                Console.WriteLine(ArrayColas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayColas.Eliminar();
//                Console.WriteLine(ArrayColas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayColas.Eliminar();
//                Console.WriteLine(ArrayColas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayColas.Eliminar();
//                Console.WriteLine(ArrayColas.Imprimir());

//                Console.WriteLine("---------------------");
//                ArrayColas.Eliminar();
//                Console.WriteLine(ArrayColas.Imprimir());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }

//        static void ListasPilas()
//        {
//            try
//            {
//                Listas.Pilas pilas = new Listas.Pilas();

//                pilas.Agregar("Cero");
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Agregar("Dos");
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Agregar("Tres");
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Agregar("Cuatro");
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("- - - - - - - - - - - - - ");

//                Console.WriteLine("-------------------");
//                pilas.Eliminar();
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Eliminar();
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Eliminar();
//                Console.WriteLine(pilas.Imprimmir());

//                Console.WriteLine("-------------------");
//                pilas.Eliminar();
//                Console.WriteLine(pilas.Imprimmir());
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }

//        static void ListasColas()
//        {
//            try
//            {
//                Listas.Colas colas = new Listas.Colas();

//                colas.Agregar("Cero");
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Agregar("Dos");
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Agregar("Tres");
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Agregar("Cuatro");
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Eliminar();
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Eliminar();
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Eliminar();
//                Console.WriteLine(colas.Imprimir());

//                Console.WriteLine("---------------");
//                colas.Eliminar();
//                Console.WriteLine(colas.Imprimir());

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//        }
//    }
//}
//Console.WriteLine("------ ARREGLOS PILAS-------");

//Arreglos.Pilas pilas = new Arreglos.Pilas(5);
//pilas.Agregar("cero");
//pilas.Agregar("Uno");
//pilas.Agregar("Dos");
//pilas.Agregar("Tres");
//pilas.Agregar("Cuatro");



