// Logica buleana
var cantidad1 = 5;
var cantidad2 = 6;

var cantidad1IgualACantidad2 = cantidad1 == cantidad2;

var cantidad1EsDiferenteACantidad2 = cantidad1 != cantidad2;

Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales? {cantidad1IgualACantidad2} ");
Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes? {cantidad1EsDiferenteACantidad2} ");

var esCantidad1MenorQue10 = cantidad1 < 10;
var esCantidad1MayorQue10 = cantidad1 > 10;

var esCantidad1MenorOIgualQue10 = cantidad1 <= 10;
var esCantidad1MayorOIgualQue10 = cantidad1 <= 10;

var nombre1 = "Felipe";
var nombre2 = "Enrique";

var sonLosNombresIguales = nombre1 == nombre2;

var esNombreNulo = nombre1 is null;

// Operadores condicionales

var cantidad3 = 6;

// //true && true => true
// //false && true => false
var estaEntre5y10 = cantidad3 >5 && cantidad3< 10;

Console.WriteLine($"¿Esta el {cantidad3} entre 5 y 10? {estaEntre5y10}");

// //true || true => true
// //false || true => true
var cantidad3Es5o6 = cantidad3 == 5 || cantidad3 == 6;

Console.WriteLine($"¿Es la cantidad {cantidad3} un numero entre el 5 o el 6? {estaEntre5y10}");

// // Sentencias
var cantidad4 = 5;
if (cantidad4 > 5){
    Console.WriteLine("Es mayor a 5");
    Console.WriteLine("Procesando...");
}
else{ // Esto es para cuando if es false
    Console.WriteLine("Es menor o igual a 5");
}

Console.WriteLine("Fin");

// Operador ternario

bool usuarioEstaLogueado = false;
// string mensajeDeBienvenida;

// if (usuarioEstaLogueado){
//     mensajeDeBienvenida = "Que bueno que has vuelto!";
// }
// else{
//     mensajeDeBienvenida = "Logueate para comenzar";
// }

// // Para aplicar el operador ternario se necesita una condicion
// // <condicion> ? <si la condicion es true> : <si la condicion es false>
string mensajeDeBienvenida1 = usuarioEstaLogueado ? "Que bueno que has vuelto!" : "Logueate para comenzar";

Console.WriteLine(mensajeDeBienvenida1);

// Sentencia de seleccion switch
var lugar = 5;
switch (lugar){
    case 1: 
        Console.WriteLine("Quedate en primer lugar!");
        break;
    case 2:
        Console.WriteLine("Quedate en segundo lugar!");
        break;
    case 3:
        Console.WriteLine("Quedate en tercer lugar!");
        break;
    case 4:
    case 5:
        Console.WriteLine("Casi lo lograste");
        break;
    default:
        Console.WriteLine("Lo lamento sigue intentando");
        break;
}
// Se puede mejorar
var lugar1 = 2;
var mensaje = lugar1 switch{
    1 => "Quedate en primer lugar!",
    2 => "Quedate en segundo lugar!",  
    3 => "Quedate en tercer lugar!",
    4 or 5 => "Casi lo logras",
    _  => "Mejor suerte para la proxima"     
};
Console.WriteLine(mensaje);

// Bucles
int contador = 1;
while(contador <= 10){
    Console.WriteLine(contador);
    contador++;
}

var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;
while (contadorInteres <= 10){
    balance *= interes;
    contadorInteres++;
}

Console.WriteLine(balance);

// Bucle de for

for( int contador2 = 1; contador2 <= 10; contador2++){
    Console.WriteLine(contador2);
}

// // Bucle infinito
while (true){
    Console.WriteLine("Te damos la bienvenida a la calculadora de suma con C#");
    Console.Write("Escriba el primer numero: ");
    var entradaUsuario = Console.ReadLine();

    if(entradaUsuario is null){
        Console.WriteLine("Error. Vuelve a intentar");
        continue;
    }

    var numero4 = decimal.Parse(entradaUsuario);

    Console.Write("Escriba el segundo numero: ");
    entradaUsuario = Console.ReadLine();

    if(entradaUsuario is null){
        Console.WriteLine("Error. Vuelve a intentar");
        continue;
    }
    var numero5 = decimal.Parse(entradaUsuario);

    Console.WriteLine($"El resultado de sumar {numero4} y {numero5} es {numero4 + numero5}");
    Console.Write("¿Desea sumar otra vez? (y/n)");
    entradaUsuario = Console.ReadLine();

    if(entradaUsuario != "y"){
        break;
    }

}
Console.WriteLine("Nos vemos");