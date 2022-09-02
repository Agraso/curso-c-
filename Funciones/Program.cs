// // Ejemplo 1: Ejemplo sencillo

void ImprimirEnConsola(string mensaje, bool enMayusculas = true)
{
    if (enMayusculas){
        mensaje = mensaje.ToUpper();
    }

    Console.WriteLine(mensaje);
}

var nombre = "Enrique";
ImprimirEnConsola(nombre);

// // Ejemplo 2: Usando Constantes
const bool mayusculas = true;
void ImprimirEnConsola1(string mensaje1, bool enMayusculas1 = mayusculas)
{
    if (enMayusculas1){
        mensaje1 = mensaje1.ToUpper();
    }

    Console.WriteLine(mensaje1);
}

var nombre1 = "Enrique";
ImprimirEnConsola1(nombre1);

// Ejemplo de arreglos 1: Pasando por un arreglo normal

double Promedio(int[] numeros)
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;   
    }
    return suma / numeros.Length;
}

var promedio1 = Promedio(new int[] { 1, 5, 7, 2});
Console.WriteLine("Promedio1:" + promedio1);

// // Ejemplo 2: Pasando un arreglo usando params

double Promedio2(params int[] numeros)
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;   
    }
    return suma / numeros.Length;
}

var promedio2 = Promedio2( 1, 5, 7, 2);
Console.WriteLine("Promedio2:" + promedio2);

// Expresiones lanmda =>
int Sumas(int a, int b) => a+b; // Se entiende que no se necesita return

// // Ejemplo 1: Funcion void que no recibe parametros

Action imprimirMensaje;

void ImprimirFechaYHora()
{
    Console.WriteLine(DateTime.Now.ToString());
}

void ImprimirMiNombre()
{
    Console.WriteLine("Enrique");
}

// imprimirMensaje = ImprimirFechaYHora;
// imprimirMensaje();

// imprimirMensaje = ImprimirMiNombre;
// imprimirMensaje();

void Procesar(Action action)
{
    Console.WriteLine("Antes de ejecutar el action");
    action();
    Console.WriteLine("Despues de ejecutar el action");
}
    imprimirMensaje = ImprimirFechaYHora;
    Procesar(imprimirMensaje);
    Console.WriteLine();
    Procesar(ImprimirMiNombre);

// Ejemplo 2: Funcion que recibe un parametro

Action<int> alterarNumero;
void Sumar1(int valor)
{
    valor++;
Console.WriteLine("El valor + 1 es " + valor);
}
//  alterarNumero = Sumar1;
//  alterarNumero(3);

 // // Ejemplo 3: Funcion void que recibe 2 parametros

 Action<string, int> imprimirNVeces;
 void Imprimir(string mensaje2, int veces)
 {
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine(mensaje2);
    }
 }

 imprimirNVeces = Imprimir;
 imprimirNVeces("Enrique", 12);

// Ejemplo 1: Funcion que retona un string pero no recibe parametros

Func<string> retornarString;
string ObtenerFechaYHoraActual()
{
    return DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
}

retornarString = ObtenerFechaYHoraActual;
var resultado = retornarString();
Console.WriteLine(resultado);

void Procesar1(Func<string> productorDeValor)
{
    Console.WriteLine("Linea anterior");
    var valor = productorDeValor();
    Console.WriteLine("El valor es " + valor);
    Console.WriteLine("Linea posterior");
}

Procesar1(retornarString);
Console.WriteLine();

// // Ejemplo 2: Un func que recibe parametros

Func<int, string> recibeEnteroRetornaString;

string ObtenerNombreDelMes(int mes)
{
    var fecha = new DateTime(2022, mes, 1);
    return fecha.ToString("MMMM");
}

recibeEnteroRetornaString = ObtenerNombreDelMes;

var mayo = recibeEnteroRetornaString(5);
Console.WriteLine(mayo);

// // El predicado es como un Func pero retorna es un bool
