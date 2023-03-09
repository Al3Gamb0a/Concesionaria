namespace Concesionaria;

  class Automovil{

    public string ID;
    public string Marca;
    public string Modelo;
    public int Km;
    public double Precio;

    public Automovil(string iD, string marca, string modelo, int km, double precio)
    {
        ID = iD;
        Marca = marca;
        Modelo = modelo;
        Km = km;
        Precio = precio;
    }

    public override string ToString(){
      return $"ID: {this.ID}, Marca: {this.Marca}, Modelo {this.Modelo}, KM: {this.Km}, Precio: {this.Precio}";
    }
  }