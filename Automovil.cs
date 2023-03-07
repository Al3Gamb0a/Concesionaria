namespace Concesionaria;

class Automovil{

    string ID = "";

    string Marca = "";

    string Modelo = "";

    int Km = 0;

    double Precio = 0;

    public override string ToString(){
       
        return "ID: " + ID + "Marca: " + Marca+ "Modelo: "+ Modelo + "Kilometraje: "+ Km + "Precio: " + Precio;
    }

}