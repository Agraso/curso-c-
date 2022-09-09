

using Clases;

var carro1 = new Carros();
carro1.Marca = "Jeep";
carro1._año = 2002;

Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

carro1.Acelerar();
carro1.Detener();

Console.WriteLine($"{carro1.NombreComercial}; velocidad = {carro1.Velocidad}");

var carro2 = new Carros();
carro2.Marca = "Daewood";
carro2._año = 2000;

Console.WriteLine(carro2.Marca);

// Usando Calculadora

var calculadora = new Calculadora();

var resultadoDT = calculadora.CalcularDuploTriplo(3);

// Ejemplo 0: sin deconstructor

// var valor = resultadoDT.Valor;
// var duplo = resultadoDT.Duplo;
// var triplo = resultadoDT.Triplo;

// Ejemplo 1: Explicita

// int valor, duplo, triplo;
// resultadoDT.Deconstruct(out valor, out duplo, out triplo);

// Ejemplo 2: Forma resumida
// resultadoDT.Deconstruct(out int valor, out int duplo, out int triplo);

// Ejemplo 3: Sin usar Deconstruct directamente
// (var valor,var duplo, var triplo) = resultadoDT;

// Ejemplo 4: Lo mas resumido posible
var (valor,duplo,triplo) = resultadoDT;

Console.WriteLine("El valor es " + valor);
Console.WriteLine("El duplo es " + duplo);
Console.WriteLine("El Triplo es " + triplo);

var carro3 = new Carros();
var carro4 = new Carros();
var carro5 = new Carros();
var carro6 = new Carros();

Console.WriteLine();

Console.WriteLine($"Han sido instanciados {Carros.ConteoInstancias} carros");

var mensaje = @"Este es un mensaje,

atentamente: Enrique";

var cantidadPalabras = mensaje.ContrarPalabras();

Console.WriteLine("Cantidad de palabras " + cantidadPalabras);

// // Ejemplo 2: Patron con varias propiedades

var carro = new Carros("Toyota");

carro._año = 2015;

if (carro is {Marca: "Toyota" or "Hyundai", _año: > 2010})
{
    Console.WriteLine("Es un carrazo!");
} else if (carro is {Marca: "Mercedes", Velocidad: > 25})
{
    Console.WriteLine("Vas rapido en tu mercedes");
} else if (carro is { _año: < 2000})
{
    Console.WriteLine("Te ha durado esa maquina");
}


// switch (carro)
// {
//     case
//     { Marca: "Toyota" or "Hyundai", _año: > 2010 }:
//         Console.WriteLine("Es un carrazo!");
//         break;
//     case
//     { Marca: "Mercedes", Velocidad: > 25 }:
//         Console.WriteLine("Vas rapido en tu mercedes");
//         break;
//     case
//     { _año: < 2000 }:
//         Console.WriteLine("Te ha durado esa maquina");
//         break;

// Record posicional

var empresa1 = new Empresa("Udemy" , 2010);

// // Error, no podemos modificar nombre, es inmutable
// // empresa1.Nombre = "Google";

var (nombre, año) = empresa1;

Console.WriteLine("El nombre de la empresa es:" + nombre);
Console.WriteLine("El año de la empresa es:" + año);
