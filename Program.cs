namespace Concesionaria;
class Program
{
    static void Main(string[] args){

        bool MostrarMenu=true;
        while(MostrarMenu){
            MostrarMenu = Menu();
        }
    }

    public static bool Menu(){

        Console.Clear();
        Console.WriteLine("BIENVENDID@ A LA CONCESIONARIA\n");
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("2.- Eliminar Automovil");
        Console.WriteLine("3.- Buscar Automovil");
        Console.WriteLine("4.- Listar todos");
        Console.WriteLine("5.- Salir");
        Console.Write("Tu opción: ");

        switch(Console.ReadLine()) {

                case "1": 
                Console.WriteLine("Seleccionaste 1");
                Console.ReadLine();
                return true;

                case "2": 
                Console.WriteLine("Seleccionaste 2");
                Console.ReadLine();
                return true;

                case "3": 
                Console.WriteLine("Seleccionaste 3");
                Console.ReadLine();
                return true;

                case "4": 
                Console.WriteLine("Seleccionaste 4");
                Console.ReadLine();
                return true;

                case "5": 
                Console.WriteLine("Gracias por usar :)");
                Console.ReadLine();
                return false;
                default:
                return true;
        }
    }
}