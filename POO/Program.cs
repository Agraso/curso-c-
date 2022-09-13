using POO;

var carro = new Carro();
carro.Marca = "Toyota";
carro.EncenderRadio();

var camion = new Camion();
camion.Marca = "Mercedes";

var bicicleta = new Bicicleta();
bicicleta.Marca = "Scott";

LeerMarca(carro);
LeerMarca(camion);
LeerMarca(bicicleta);

void LeerMarca(Vehiculo vehiculo)
{
    var mensaje = $"Leyendo la marca {vehiculo.Marca} del vehiculo de tipo {vehiculo}";
    Console.WriteLine(mensaje);
}

Console.Write("Carro: ");
carro.DarReversa();
Console.WriteLine("--");

Console.Write("Carro: ");
camion.DarReversa();
Console.WriteLine("--");

Console.Write("Carro: ");
bicicleta.DarReversa();
Console.WriteLine("--");
