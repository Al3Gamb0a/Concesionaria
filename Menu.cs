namespace Concesionaria;

    class Menu{
        
        Concesionario concesionario = new Concesionario(10);

    public bool ShowMenu(){

        //Console.Clear();
        Console.WriteLine("\nBIENVENDID@ A LA CONCESIONARIA\n");
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("2.- Eliminar Automovil");
        Console.WriteLine("3.- Buscar Automovil");
        Console.WriteLine("4.- Listar todos");
        Console.WriteLine("5.- Vaciar Concesionaria");
        Console.WriteLine("6.- Salir");
        Console.Write("Tu opción: ");

        switch(Console.ReadLine()) {

                case "1": 
                AgregarAutomovil();
                return true;

                case "2": 
                EliminarAuto();
                Console.ReadLine();
                return true;

                case "3": 
                BuscarAuto();
                Console.ReadLine();
                return true;

                case "4": 
                MostrarConcesionaria();
                Console.ReadLine();
                return true;

                case "5":
                VaciarConcesionaria();
                Console.ReadLine();
                return true;

                case "6": 
                Console.WriteLine("Gracias por usar :)");
                Console.ReadLine();
                return false;
                default:
                return true;
        }
    }
    public void AgregarAutomovil(){

        //Console.Clear();
        Console.WriteLine("\nCreando nuevo automóvil . . .");

        Console.Write("ID: ");
        string? ID = Console.ReadLine();

        Console.Write("Marca: ");
        string? Marca = Console.ReadLine();

        Console.Write("Modelo: ");
        string? Modelo = Console.ReadLine();

        Console.Write("Kilometraje: ");
        string? Km = Console.ReadLine();

        Console.Write("Precio: ");
        string? Precio = Console.ReadLine();

        Automovil nuevo = new Automovil(ID, Marca, Modelo, Convert.ToInt32(Km), Convert.ToDouble(Precio));

        concesionario.AgregarAuto(nuevo);
        Console.WriteLine("Auto agregado correctamente :)");
        }

        public void EliminarAuto(){
            Console.WriteLine("Dame el ID a eliminar: ");
            string? ID = Console.ReadLine();
            concesionario.EliminarAuto(ID);
            Console.WriteLine("El auto se eliminó correctamente, wuuu");

        }

        public void BuscarAuto(){
            Console.WriteLine("Dame la ID a buscar: ");
            string? ID = Console.ReadLine();
            concesionario.MostrarAuto(ID);
            Console.WriteLine("Aquí está tu carrito, wuuu");
        }

        public void MostrarConcesionaria(){
            concesionario.MostrarAutos();
        }

        public void VaciarConcesionaria(){
            concesionario.VaciarConcesionaria();
        }
    }
