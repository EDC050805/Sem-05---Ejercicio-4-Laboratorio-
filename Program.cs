// See https://aka.ms/new-console-template for more information

Console.WriteLine("\tPrograma para ejecutar un proceso según una opción");
Console.WriteLine("\t**************************************************\n");
Console.Write("Ingrese el número límite: ");
int lim = int.Parse(Console.ReadLine());
Console.WriteLine("==============================");
Console.WriteLine("Escoja una opción: ");
Console.WriteLine("1: Números pares");
Console.WriteLine("2: Números impares");
Console.WriteLine("3: Factorial");
Console.Write("-> ");
int opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        {
            for (int i = 1; i <= lim; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
        break;
    case 2:
        {
            for (int i = 1; i <= lim; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
        break;
    case 3:
        {
            long factorial = 1;
            for (int i = 1; i <= lim; i++)
            {
                factorial *= i;
            }            
            Console.WriteLine("El factorial es: " + factorial);
        }
        break;
    default:        
            Console.WriteLine("¡Error! Debe ingresar una opción del menú anterior");                    
        break;
}
Console.ReadKey();