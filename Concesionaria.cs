namespace Concesionaria;

class Concesionaria{
    public List<string> Automoviles;
    int  Limite;
    int NumeroActual;

    public Concesionaria(int Limite){
    
        this.Limite=Limite;

        Automoviles = new List <string> (Limite);

        NumeroActual = 0;
    }

    public void AgregarAuto(Automovil a){

    }   

    public void MostrarAuto(Automovil a){

    } 

    public void EliminarAuto(Automovil a){

    }

    public void MostrarAutos(){

    }

    public void VaciarConcesionaria(){
        
    }
}