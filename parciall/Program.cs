using System;

class Program
{
    static void Main(string[] args)
    {
        //EJERCICIO 1
        int numero;

        do
        {
            Console.WriteLine("\nEjercicio 1:");
            Console.Write("Ingrese un numero entero: ");
        } while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

        int opcion;

        // Ciclo principal del menú
        do
        {
            // Muestra el menú al usuario
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Calcular el factorial del número.");
            Console.WriteLine("2. Calcular la raíz cuadrada del número.");
            Console.WriteLine("3. Salir del programa.");
            Console.Write("Elija una opción: ");

            // Valida que la opción ingresada sea un número entero
            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.Write("Opción inválida. Por favor, ingrese un número: ");
            }

            switch (opcion)
            {
                case 1:
                    // Calcular y mostrar el factorial del número
                    Console.WriteLine($"El factorial de {numero} es: {Factorial(numero)}");
                    break;
                case 2:
                    // Calcular y mostrar la raíz cuadrada del número
                    Console.WriteLine($"La raíz cuadrada de {numero} es: {Math.Sqrt(numero)}");
                    break;
                case 3:
                    // Salir del programa
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    // Mostrar un mensaje de error si la opción no es válida
                    Console.WriteLine("Opción inválida. Por favor, elija una opción válida.");
                    break;
            }

        } while (opcion != 3);

        // Método para calcular el factorial de un número
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }



     
        Console.WriteLine("\nEjercicio 2:");

        Console.WriteLine("Ingrese el primer número entero:");
        int numero1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el segundo número entero:");
        int numero2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Ingrese el operador matemático (+, -, *, /):");
        char operador = Convert.ToChar(Console.ReadLine());
         // Realizar la operación indicada
        double resultado = 0; 

        switch (operador)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                
                resultado = (double)numero1 / numero2;
                break;
            default:
                Console.WriteLine("Operador no válido.");
                return;
        }

        Console.WriteLine("El resultado es: " + resultado);



        // EJERCICIO 3
        // Imprimir la tabla de multiplicar para un número dado por el usuario
        Console.WriteLine("\nEjercicio 3:");
        
        Console.WriteLine("Ingrese un número para imprimir su tabla de multiplicar:");
        int numeroEjercicio3;

        while (!int.TryParse(Console.ReadLine(), out numeroEjercicio3))
        {
           
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero:");
        }

         Console.WriteLine($"Tabla de multiplicar del {numeroEjercicio3}:");
        for (int i = 1; i <= 10; i++)
        {
            // Multiplicar el número ingresado por cada número del 1 al 10 e imprimir el resultado
            Console.WriteLine($"{numeroEjercicio3} x {i} = {numeroEjercicio3 * i}");
        }


        // EJERCICIO 4
        // Juego para adivinar un número secreto
        Console.WriteLine("\nEjercicio 4:");
        Random rand = new Random(); // Objeto para generar números aleatorios
        int numeroSecreto = rand.Next(1, 101); // Genera un número aleatorio entre 1 y 100
        int intentos = 0;
        int intentoUsuario;

        Console.WriteLine("¡Bienvenido al juego de adivinar un número secreto entre 1 y 100!");

        // El bucle se ejecutará hasta que el usuario adivine el número secreto
        while (true)
        {
            Console.Write("Introduce un número: ");
            intentoUsuario = Convert.ToInt32(Console.ReadLine()); 
            intentos++; // Incrementa el contador de intentos

            // Compara el número introducido por el usuario con el número secreto
            if (intentoUsuario < numeroSecreto)
            {
                Console.WriteLine("El número secreto es mayor que " + intentoUsuario);
            }
            else if (intentoUsuario > numeroSecreto)
            {
                Console.WriteLine("El número secreto es menor que " + intentoUsuario);
            }
            else
            {
                Console.WriteLine($"¡Felicidades has adivinado el numero secreto {numeroSecreto} en {intentos} intentos!");
                break; 
            }
        }
    }
}
