namespace Plantilla_DesafiosExtra_Examen_POO
{
    internal class Program
    {
        static List<string> juegos = new List<string>();

        public static void Main()
        {
            while (true)
            {
                
                    Console.WriteLine("1. Agregar videojuego");
                    Console.WriteLine("2. Mostrar videojuegos");
                    Console.WriteLine("3. Salir");
                    Console.Write("Elige una opción: ");

                try
                {
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            AgregarVideojuego();
                            break;
                        case 2:
                            Console.Clear();
                            MostrarVideojuegos();
                            break;
                        case 3:
                            Console.WriteLine("¡Hasta luego!");
                            Environment.Exit(0);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Error: El número ingresado es demasiado grande o pequeño.");
                        /*he cambiado el default para que cuando el usuario introduzca un numero fuera del rango de las opciones del switch.
                         *el switch por si solo no lanza excepciones, asi que la lanzo en el default.*/
                        
                    }
                }

                //catch para cuando el usuario introduzca un formativo invalido como opcion en el switch (ej. letras)
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: Debes ingresar un número válido.");
                }
                //catch para cuando el usuario introduzca un numero fuera del rango de las opciones del switch
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void AgregarVideojuego()
        {
            try
            {
                Console.Write("Ingresa el nombre del videojuego: ");
                string juego = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(juego))
                {
                    throw new ArgumentException("El nombre del videojuego no puede estar vacío.");
                }

                juegos.Add(juego);
                Console.WriteLine("¡Videojuego agregado!");
            }
            //catch para cuando el usuario no introduce nada y queda una cadena vacia en juego
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        static void MostrarVideojuegos()
        {
            if (juegos.Count == 0)
            {
                Console.WriteLine("No hay videojuegos.");
            }
            else
            {
                Console.WriteLine("Videojuegos:");
                foreach (var juego in juegos)
                {
                    Console.WriteLine(juego);
                }
            }
        }
    }
}