using System;

namespace RepasoParcial1
{
    internal class Program
    {
        //Variables globales
        static int edad, dni, nota, opcion;
        static string nombre, apellido;
        static bool aprobo, existe = false;
        static void Main(string[] args)
        {
            void AñadirEstudiante()
            {
                Console.Write("Ingrese nombre: ");
                nombre = Console.ReadLine();

                Console.Write("Ingrese apellido: ");
                apellido = Console.ReadLine();

                Console.Write("Ingrese DNI: ");
                dni = int.Parse(Console.ReadLine());

                Console.Write("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Ingrese nota: ");
                nota = int.Parse(Console.ReadLine());

                if (nota >= 4)
                {
                    aprobo = true;
                }
                else 
                {
                    aprobo = false;
                }
                //El usuario pasa a estar registrado
                existe = true;
            }

            void MostrarInformacion()
            {
                if (existe)
                {
                    Console.WriteLine($"Nombre: {nombre}");
                    Console.WriteLine($"Apellido: {apellido}");
                    Console.WriteLine($"DNI: {dni}");
                    Console.WriteLine($"Edad: {edad}");
                    Console.WriteLine($"Nota: {nota}");
                    if (aprobo)
                    {
                        Console.WriteLine("El alumno aprobo");
                    }
                    else
                    {
                        Console.WriteLine("El alumno desaprobo");
                    }
                }
                else
                {
                    Console.WriteLine("El usuario no existe");
                }
            }

            string EstadoCursada(int nota1)
            {
                string estado;
                if (nota < 4)
                {
                    estado = "Desaprobado";
                }
                else
                {
                    if (nota < 7)
                    {
                        estado = "Rinde final";
                    }
                    else 
                    {
                        estado = "Promocionado";
                    }
                }
                return estado;
            }

            int ContarVocales(string apellido, string nombre)
            {
                int cantidadVocales = 0;
                string nombreCompleto = apellido + nombre;
                int cantidadLetras = (nombreCompleto).Length;
                for (int i = 0; i < cantidadLetras; i++) 
                {
                    if (nombreCompleto[i] == 'a' || nombreCompleto[i] == 'e' || nombreCompleto[i] == 'i' || nombreCompleto[i] == 'o' || nombreCompleto[i] == 'u') 
                    {
                        cantidadVocales++;  
                    }
                }
                return cantidadVocales;
            }

            void MenuOpciones()
            {
                Console.WriteLine();
                Console.WriteLine("Selecciona una opcion");
                Console.WriteLine("1. Añadir un estudiante");
                Console.WriteLine("2. Mostrar informacion del estudiante");
                Console.WriteLine("3. Mostrar el estado de la cursada basado en su nota");
                Console.WriteLine("4. Contar y mostrar la cantidad de vocales que contiene el alumno(entre nombre y apellido)");
                Console.WriteLine("5. Salir del programa");
            }

            //Programa principal 
            do
            {
                MenuOpciones();
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcion)
                {
                    case 1:
                        AñadirEstudiante();
                        break;
                    case 2:
                        MostrarInformacion();
                        break;
                    case 3:
                        Console.WriteLine("El estado de la cursada es: " + EstadoCursada(nota));
                        break;
                    case 4:
                        Console.WriteLine("Cantidad de vocales nombre completo: " + ContarVocales(nombre, apellido));
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta !!!, vuelva a ingresar otra opcion");
                        break;
                }
            }
            while (opcion != 5);
        }
    }
}
