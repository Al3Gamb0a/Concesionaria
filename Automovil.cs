namespace Concesionaria;

  class Automovil{

    string ID = "";
    string Marca = "";
    string Modelo = "";
    int Km;
    double Precio;

    public override string ToString(){
      return $"ID: {ID}, Marca: {Marca}, Modelo {Modelo}, KM: {Km}, Precio: {Precio}";
    }
  }