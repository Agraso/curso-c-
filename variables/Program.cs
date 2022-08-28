
char primeraLetraDelABC = 'A';// Representa un solo caracter

string nombre = "Enrique Agraso"; // Representa un conjunto de caracteres
string texto = "Mi amigo me dijo una vez: \"Me caes bien\"";
string caracterDeEscape = "En C# podemos usar \\ para escapar strings";

Console.WriteLine(primeraLetraDelABC);
Console.WriteLine(nombre);
Console.WriteLine(texto);
Console.WriteLine(caracterDeEscape);

// Verbating nos permite escapar sin el \ pero tenemos que poner doble comilla 
string carta = @"A quien pueda interesar, 

Estimado cliente, debe mucho dinero.

Att: La administración";

string directorioDelArchivo = @"C:/Mis documentos/Mi carpeta/excel.xlsx";

Console.WriteLine(carta);

//// Tiempo o DateTime
DateTime ahora = DateTime.Now; // Valor del momento
DateTime primerDiaDelAño = new DateTime(2022, 1, 1); //Valor fijo
DateTime mañana = DateTime.Now.AddDays(1);

Console.WriteLine(ahora);
Console.WriteLine(primerDiaDelAño);
Console.WriteLine(mañana);
Console.WriteLine("El dia es:");
Console.WriteLine(mañana.Day);

Console.WriteLine("El dia del año es:");
Console.WriteLine(mañana.DayOfYear);

Console.WriteLine("El dia de la semana es:");
Console.WriteLine(mañana.DayOfWeek);

//// Se puede declarar una variable con var pero se tiene que terminar la linea de codigo 
var edadDeFelipe = 999;
var apellido = "Agraso";
var hoy = DateTime.Now;
var float1 = 1.9f;

Console.WriteLine(edadDeFelipe);
Console.WriteLine(apellido);
Console.WriteLine(hoy);

// Clase valores por defecto
// Un tipo de valor puede ser nulificado si se le pone un ?
int edad = default;
Console.WriteLine("Valor por defecto de int: ");
Console.WriteLine(edad);

bool hoyEsDomingo = default;
Console.WriteLine("Valor por defecto de bool: ");
Console.WriteLine(hoyEsDomingo);

decimal precio = default;
Console.WriteLine("Valor por defecto de decimal: ");
Console.WriteLine(precio);

DateTime hoy1 = default;
Console.WriteLine("Valor por defecto de DateTime: ");
Console.WriteLine(hoy1);

string nombre1 = null;
Console.WriteLine("Valor por defecto de string: ");
// Va a dar un error
Console.WriteLine(nombre1.ToUpper());

// clase de sumatoria
var cantidad1 = 7; //// Si se le pone m se vuelve punto decimal y se aplica en todas las operaciones
var cantidad2 = 5;
var resultadoSuma = cantidad1 + cantidad2;
var resultadoResta = cantidad1 - cantidad2;
var resultadoMultiplicacion = cantidad1 * cantidad2;
var resultadoDivision = (double) cantidad1 / cantidad2;
var resultadoResiduo = cantidad1 % cantidad2;

Console.WriteLine("La suma de " + cantidad1 + " y " + cantidad2 + " es igual a: ");
Console.WriteLine(resultadoSuma);
Console.WriteLine("La resta es " + resultadoResta);
Console.WriteLine("La multiplicación de " + cantidad1 + " y " + cantidad2 + " es igual a: ");
Console.WriteLine(resultadoMultiplicacion);
Console.WriteLine("La división es " + resultadoDivision);
Console.WriteLine("El residuo de " + cantidad1 + " y " + cantidad2 + " es igual a: ");
Console.WriteLine(resultadoResiduo);

Console.WriteLine("La suma de " + cantidad1 + " y " + cantidad2 + " es igual a: ");
Console.WriteLine(resultadoSuma);

var nombre2 = "Enrique";
var apellido2 = "Agraso";

var resultadoString = nombre2 + apellido2;

Console.WriteLine("Podemos concadenar strings con + ");
Console.WriteLine(resultadoString);

// Clase de sumatoria 2
var maximo = int.MaxValue;
var suma = checked ( maximo + 1); // Generara un error porque se sale de los valores maximos.

Console.WriteLine(maximo);
Console.WriteLine(suma);

// Clase de suma 3 Con llaves no hace falta hacer tanta mierda
var cantidad5 = 7;
var cantidad6 = 4;
var resultado = cantidad5 + cantidad6;
var nombre5 = "Enrique";
var apellido5 = "Agraso";

Console.WriteLine ("La suma de " + cantidad5 + " y " + cantidad6 + " es igual a : " + resultado);
Console.WriteLine ($"La suma de {cantidad5} y {cantidad6} es igual a: {resultado}");
Console.WriteLine($"Mi nombre es {nombre5.ToUpper()} {apellido5}");

var cantidad1PorMenos1 = -cantidad5; // (-1) * cantidad

Console.WriteLine(cantidad1PorMenos1);

cantidad5++; // Cantidad1 = cantidad1 + 1
cantidad5--; // Cantidad1 = cantidad1 - 1
++cantidad5; // Cantidad1 = cantidad1 + 1 aqui se evalua primero la suma y despues contra la otra cantidad
--cantidad5; // Cantidad1 = cantidad1 - 1 aqui se evalua primero la resta y despues contra la otra cantidad

var suma6 = ++cantidad5 + cantidad6;
Console.WriteLine("suma es" + suma6);

cantidad5 += cantidad6; // Esto es cantidad1 = cantidad1 + cantidad2 y se altera cantidad 1
Console.WriteLine("Cantidad1 es" + cantidad1);

cantidad5 -= cantidad6;
Console.WriteLine("Cantidad1 regresara a su valor = " + cantidad1);


