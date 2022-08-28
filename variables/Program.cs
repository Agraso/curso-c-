// See https://aka.ms/new-console-template for more information

// Clase de variable int
int edad; 
edad = 20;

int alturaEnCentimetros = 34;

int distanciaDeLaTierraAlSolEnKilometros = 15_000_000;

Console.WriteLine(edad);

Console.WriteLine(alturaEnCentimetros);

Console.WriteLine(distanciaDeLaTierraAlSolEnKilometros);

// Clase de variables de numeros
uint uintl = 3_000_000; // 0 hasta mas o menos 4 mil millones

long long1 = 8_000_000_000_000; // -9,223,372,036,854,775,808 hasta -9,223,372,036,854,775,808 
ulong ulong1 = 16_000_000_000_000; // 0 hasta 18,446,744,073,709,551,615

byte bytel = 145; // 0 hasta 255
sbyte sbytel = 100; // -128 hasta 127

short shortl = 30_00; // -32,768 hasta 32,767
ushort ushortl = 65_000; // 0 hasta 65.353

// Clase de numeros decimales
float altura = 180.123456789f; // Ocupa 4 bytes; Precisión de 6 a 9 digitos
double anchura = 45.123456789; // Ocupa 8 bytes; Precisión de 15 a 17 digitos
decimal monto = 9.99m; // Ocupa 16 bytes; Precisión de 28 a 29 digitos (es recomendado en temas financieros)

Console.WriteLine("La altura es");
Console.WriteLine(altura);
Console.WriteLine("La anchura es");
Console.WriteLine(anchura);
Console.WriteLine("El precio es");
Console.WriteLine(monto);

// Clase de si o no Funciona para tener dos decisiones 
bool soyEnrique = true;
bool dosMasDosEsCinco = false;

// Clase de console.

Console.WriteLine("Hello, World!");

Console.WriteLine("Yo soy Enrique Agraso; mi edades 222");

// Este es un ejemplo
{
    Console.WriteLine("Este codigo esta dentro de un bloque");
}

Console.WriteLine("este codigo no esta en el bloque");