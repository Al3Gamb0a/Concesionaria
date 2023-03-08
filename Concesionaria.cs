namespace Concesionaria;

  class Concesionario{

    List<Automovil> Automovil;
    int Limite;
    int AutosActual;

    public Concesionario(int Limite){

      Automovil = new List<Automovil>();
      this.Limite = Limite;
      AutosActual = 0;
    }

    public void AgregarAuto(Automovil a){

      if(a != null){
        if(AutosActual <= Limite){
          Automovil.Add(a);
          AutosActual++;
        }
      }
    }

    public void MostrarAuto(Automovil a){
      if(a != null){
        foreach(Automovil item in Automovil){

          if(item == a){
            Console.WriteLine(item);
            return; 
          }
        }
        Console.WriteLine("El automovil que buscas no está en la Concesionaria");
      }
    }

    public void EliminarAuto(Automovil a){

      if(a != null){

        foreach(Automovil item in Automovil){

          if(item == a){
            Automovil.Remove(item);
            AutosActual--;
            return;
          }
        }

          // Si no se encontro el auto 
        Console.WriteLine("El automovil no está en la consecionaria");
      }
    }

    public void MostrarAutos(){

      foreach(Automovil item in Automovil){
          Console.WriteLine(item);
	    }     
    }
    public void VaciarConcesionaria(){
      Automovil = new List<Automovil>();
      AutosActual = 0;
    }
}