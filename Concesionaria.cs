namespace Concesionaria;

  class Concesionario{

    List<Automovil> Automoviles;
    public int Limite;
    public int AutosActual;

    public Concesionario(int Limite){

      Automoviles = new List<Automovil>();
      this.Limite = Limite;
      AutosActual = 0;
    }

    public void AgregarAuto(Automovil autoNuevo){

      if(autoNuevo != null && AutosActual != Limite){
        Automovil? AutoEncontrado = Automoviles.Find((Automovil)=>Automovil.ID==autoNuevo.ID);

        if (AutoEncontrado == null){
          Automoviles.Add(autoNuevo);
          AutosActual++;
            } 
        }
      }
    

    public void MostrarAuto(string ID){
  
    Automovil? AutoEncontrado = Automoviles.Find((a)=>a.ID==ID);

    if(AutoEncontrado!=null)
      Console.WriteLine(AutoEncontrado.ToString());
 

    }

    public void EliminarAuto(string ID){

      if(ID != "" && AutosActual!=0){
        Automovil? AutoEncontrado = Automoviles.Find((a)=>a.ID == ID);

      if (AutoEncontrado != null){
        Automoviles.Remove(AutoEncontrado);
        AutosActual --;
      }
      else{
        Console.Write("No hay autos para sacar");
      }

   /*
(a)=>a.ID == ID
  function (Automovil a){
    if (a.ID == ID)
      return a;
  }
*/
      }
          }

    public void MostrarAutos(){

      foreach(Automovil item in Automoviles){

          Console.WriteLine(item);
	    }     
    }
    public void VaciarConcesionaria(){

      Automoviles.Clear();
      Automoviles = new List<Automovil>();
      AutosActual = 0;
      Console.WriteLine("YA NO HAY CARROS");
    }
}