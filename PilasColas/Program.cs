using Arreglos;

Pilas pilas = new Pilas(10);

pilas.Agregar("Cero");
pilas.Agregar("Uno");
pilas.Agregar("Dos");
pilas.Agregar("Tres");
pilas.Agregar("Cuatro");
pilas.Agregar("Cinco");
Console.WriteLine(pilas.Imprimir());

for(int i = 0; i < 10; i++)
{
    try
    {
        Console.WriteLine("--------------------");
        pilas.Eliminar();
        Console.WriteLine(pilas.Imprimir());
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }

}

