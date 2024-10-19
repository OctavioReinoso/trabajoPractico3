using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo3
{
    /*1. Crear un vuelo (inicialmente con todos los asientos vacíos). Cada vuelo tiene 60 asientos. */
    /*2. Reservar un asiento. Si está disponible (0) lo marca como ocupado (1).*/
    /*3. Cancelar una reserva. El vuelo vuelve a estar disponible (0) */
    /*4. Mostrar el estado actual del vuelo, mostrando todos los asientos disponibles y ocupados.*/
    /*5. Mostrar la cantidad de asientos disponibles y ocupados en el vuelo  */
    /*6. Buscar un asiento en particular e indicar si el mismo está disponible */
    
    internal class Program
    {
        public static int[][] asientos = new int[60][];
        public static void Main(string[] args)
        {

            for(int i = 0; i < asientos.Length; i++)
            {
                asientos[i] = new int[1];
                asientos[i][0] = 0;
            }

            int opcionUsuario;
            bool salir = false;

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Ingrese la opcion que desea elegir:\n" +
                "0. Salir del sistema. \n" +
                "1. Reservar un asiento. \n" +
                "2. Cancelar una reserva. \n" +
                "3. Mostrar estado del vuelo. \n" +
                "4. Mostrar cantidad de asientos ocupados y disponibles. \n" +
                "5. Buscar asiento especifico (Indique el numero, y se le dira si esta disponible) \n");
            do
            {
                
                opcionUsuario = int.Parse(Console.ReadLine());
                
                switch (opcionUsuario)
                {
                    case 0:
                        Console.WriteLine("Saliendo del sistema...");
                        salir = true;
                        return;
                    case 1:
                        ReservarAsiento();
                        break;
                    case 2:
                        CancelarReserva();
                        break;
                    case 3:
                        MostrarVuelo();
                        break;
                    case 4:
                        MostrarAsientos();
                        break;
                    case 5:
                        BuscarAsientos();
                        break;
                    default:
                        Console.WriteLine("El numero ingresado no es válido");
                        break;
                }

                Console.WriteLine("Seleccione alguna de las opciones del menu si desea realizar otra operación.");

            } while (!salir);
   
        }
        
        public static void ReservarAsiento()
        {
            
            Console.WriteLine("Elija el numero de asiento: (De 0 a 59)");
            int usuarioRespuesta = int.Parse(Console.ReadLine());
            
            if (usuarioRespuesta < 0 || usuarioRespuesta > 59) 
            { 
                Console.WriteLine("Numero de asiento inválido."); 
                return; 
            }
            
            if (asientos[usuarioRespuesta][0] == 0) 
            { 
                asientos[usuarioRespuesta][0] = 1;
                Console.WriteLine($"El asiento {usuarioRespuesta} fue reservado con exito!");
            }else
            {
                Console.WriteLine("El asiento ingresado ya se encuentra ocupado.");
                return;
            }
            
        }

         public static void CancelarReserva()
         {
             Console.WriteLine("Ingrese el numero de asiento que desea cancelar: ");
             int opcionUsuario = int.Parse(Console.ReadLine());

             if(opcionUsuario < 0 || opcionUsuario > 59) 
             { 
                 Console.WriteLine("Numero de asiento invalido."); 
                 return; 
             }
             if (asientos[opcionUsuario][0] == 1) 
             { 
                 asientos[opcionUsuario][0] = 0; 
                 Console.WriteLine("Su reserva fue cancelada");
             } else
             {
                 Console.WriteLine("El asiento ingresado no ha podido ser cancelado, ya se encuentra disponible. ");
                 return;
             }
         }
         
        public static void MostrarVuelo()
        {
            Console.WriteLine("Estado del vuelo: ");

            for (int i = 0; i < asientos.Length; i++)
            {
                for(int j = 0; j < asientos[i].Length; j++)
                {
                    if (asientos[i][0] == 0)
                    {
                        Console.WriteLine($"Asiento {i} disponible");
                    }
                    else { 
                        Console.WriteLine($"Asiento {i} ocupado"); }
                    
                }
            }
        }
        
        public static void MostrarAsientos()
        {
            int contadorDisp = 0;
            int contadorOcup = 0;

            for(int i = 0; i < asientos.Length; i++)
            {
                if (asientos[i][0] == 0)
                {
                    contadorDisp++;
                } else { 
                contadorOcup++; }
            }
            Console.WriteLine($"Cantidad de vuelos disponibles: {contadorDisp}. Cantidad de vuelos ocupados: {contadorOcup}");
        }
        
        public static void BuscarAsientos()
        {
            Console.WriteLine("Cual asiento desea consultar? (inidicar el numero de butaca)");
            int asientoElegido = int.Parse(Console.ReadLine());

            if (asientoElegido < 0 || asientoElegido > 59)
            {
                Console.WriteLine("El numero de butaca ingresado no existe");
                return;
            }

            if (asientos[asientoElegido][0] == 0)
            {
                Console.WriteLine("El asiento se encuentra disponible");
            }
            else
            {
                Console.WriteLine("El asiento esta ocupado");
            }
        }
        

    }
}

