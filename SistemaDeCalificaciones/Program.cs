int contadorAprobados = 0;
int contadorDesaprobados = 0;

Console.WriteLine("---Menu Principal---");
// a ver si funca 3.0
Console.WriteLine("1- Ingresar de cantidad fija de nota");
Console.WriteLine("2- Ingresar indefinido de notas");
Console.WriteLine("3- Mostrar resumen");
Console.WriteLine("4- Salir");

Console.WriteLine("Selecciona una opción:");

string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        IngresoFijo();
        break;

    case "2":
        IngresoIndefinido();
        break;

    case "3":
        MostrarResumen();
        break;

    case "4":
        Console.WriteLine("Saliendo");
        Console.ReadLine();
        break;

    default:
        Console.WriteLine("Opción Inválida");
        Console.ReadLine();
        break;
}

void IngresoFijo()
{
    string cantidadFijo;
    float nota;
    Console.WriteLine("¿Cuantas notas quiere ingresar?");
    cantidadFijo = Console.ReadLine();

    int cantidadFijoEnNumero = int.Parse(cantidadFijo);
    for (int i = 1; i <= cantidadFijoEnNumero; i++)
    {
        Console.WriteLine($"Ingrese la nota del alumno {i}");
        nota = float.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aprobado");
            contadorAprobados++;
        }
        else
        {
            Console.WriteLine("Desaprobado");
            contadorDesaprobados++;
        }
    }
}



void IngresoIndefinido()
{
    string opcion;
    float nota;
    do
    {
        Console.WriteLine("Ingrese la nota del alumno: ");
        nota = float.Parse(Console.ReadLine());

        if (nota >= 7)
        {
            Console.WriteLine("Aprobado");
            contadorAprobados++;
        }
        else
        {
            Console.WriteLine("Desaprobado");
            contadorDesaprobados++;
        }

        Console.WriteLine("Desea ingresar otra nota? [S/N]");
        opcion = Console.ReadLine().ToUpper();
    } while (opcion != "N");
}

void MostrarResumen()
{
    Console.WriteLine($"Cantidad de aprobados: {contadorAprobados}");
    Console.WriteLine($"Cantidad de desaprobados: {contadorDesaprobados}");
    Console.ReadLine();
}