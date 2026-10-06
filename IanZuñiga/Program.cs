using System;
class Program
{
    static void Main(string[] args)
    {
        // El ultimo digito de mi carnet es 8

        int N = 18;
        string[] cedulas = new string[N];
        string[] nombres = new string[N];
        int cantidad = 0;
        int opcion = 0;

        while (opcion != 6)
        {
            Console.WriteLine();
            Console.WriteLine("HOSPITAL SAN RAFAEL");
            Console.WriteLine("1. Registrar paciente");
            Console.WriteLine("2. Buscar paciente");
            Console.WriteLine("3. Corregir nombre");
            Console.WriteLine("4. Dar de baja");
            Console.WriteLine("5. Mostrar pacientes");
            Console.WriteLine("6. Salir");
            Console.Write("Digite una opcion: ");

            opcion = int.Parse(Console.ReadLine());

            // Registrar paciente
            if (opcion == 1)
            {
                if (cantidad < N)
                {
                    Console.Write("Digite la cedula: ");
                    string cedula = Console.ReadLine();
                    bool existe = false;
                    for (int i = 0; i < cantidad; i++)
                    {
                        if (cedulas[i] == cedula)
                        {
                            existe = true;
                        }
                    }
                    if (existe == false)
                    {
                        Console.Write("Digite el nombre: ");
                        string nombre = Console.ReadLine();
                        cedulas[cantidad] = cedula;
                        nombres[cantidad] = nombre;
                        cantidad++;
                        Console.WriteLine("Paciente registrado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("La cedula ya esta registrada.");
                    }
                }
                else
                {
                    Console.WriteLine("No hay espacio disponible.");
                }
            }
            else if (opcion == 2)
            {
                Console.Write("Digite la cedula que desea buscar: ");
                string cedula = Console.ReadLine();
                bool encontrado = false;
                for (int i = 0; i < cantidad; i++)
                {
                    if (cedulas[i] == cedula)
                    {
                        Console.WriteLine("Nombre del paciente: " + nombres[i]);
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("Paciente no encontrado.");
                }
            }
            else if (opcion == 3)
            {
                Console.Write("Digite la cedula: ");
                string cedula = Console.ReadLine();
                bool encontrado = false;
                for (int i = 0; i < cantidad; i++)
                {
                    if (cedulas[i] == cedula)
                    {
                        Console.Write("Digite el nuevo nombre: ");
                        nombres[i] = Console.ReadLine();
                        Console.WriteLine("Nombre corregido correctamente.");
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {
                    Console.WriteLine("Paciente no encontrado.");
                }
            }
            else if (opcion == 4)
            {
                Console.Write("Digite la cedula del paciente: ");
                string cedula = Console.ReadLine();
                int posicion = -1;
                for (int i = 0; i < cantidad; i++)
                {
                    if (cedulas[i] == cedula)
                    {
                        posicion = i;
                    }
                }
                if (posicion != -1)
                {
                    for (int i = posicion; i < cantidad - 1; i++)
                    {
                        cedulas[i] = cedulas[i + 1];
                        nombres[i] = nombres[i + 1];
                    }
                    cantidad--;
                    Console.WriteLine("Paciente dado de baja correctamente.");
                }
                else
                {
                    Console.WriteLine("Paciente no encontrado.");
                }
            }
            else if (opcion == 5)
            {
                if (cantidad == 0)
                {
                    Console.WriteLine("No hay pacientes registrados.");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("PACIENTES REGISTRADOS");
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Cedula: " + cedulas[i]);
                        Console.WriteLine("Nombre: " + nombres[i]);
                        Console.WriteLine("-------------------------");
                    }
                }
            }
            // Salir
            else if (opcion == 6)
            {
                Console.WriteLine("Programa finalizado.");
            }
            // Opcion incorrecta
            else
            {
                Console.WriteLine("Opcion no valida.");
            }
        }
    }
}