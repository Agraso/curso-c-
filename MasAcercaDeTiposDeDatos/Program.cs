// // // Ejemplo 1: Casteo explicito

// var cantidad1 = 7;
// var cantidad2 = 4;

// var division = (double)cantidad1 / cantidad2;

// Console.WriteLine("La división es " + division);

// // // Ejemplo 2: Casteo explicito

// byte byte1;
// int int1 = 3;

// byte1 = (byte)int1;

// Console.WriteLine(byte1);

// // // Ejemplo 3: Casteo implicito

// byte byte2 = 11;
// int int2;

// int2 = byte2;

// Console.WriteLine(int2);

// // Ejemplo 1: Estatus

// using MasAcercaDeTiposDeDatos;

// var estatusDeLaVentaDeUnaCamisa = EstatusVenta.Cancelada;

// switch (estatusDeLaVentaDeUnaCamisa){
//     case EstatusVenta.Exitoso:
//         Console.WriteLine("La venta fue exitosa");
//     break;
//     case EstatusVenta.PendienteDePago:
//         Console.WriteLine("El cliente debe pagar");
//     break;
//     case EstatusVenta.Cancelada:
//         Console.WriteLine("¿Qué hice para merecer esto?");
//     break;
//     default:
//         Console.WriteLine("Estatus desconocido");
//     break;
// }

// // // Ejemplo 2: Casteo

// int estatus = (int)estatusDeLaVentaDeUnaCamisa;
// Console.WriteLine(estatus);

// int estatus3 = 3;
// var estatus3Nombre = (EstatusVenta)estatus3;
// Console.WriteLine(estatus3Nombre);

// // Ejemplo 1: Arreglo de char

// char[] vocales = new char[5];

// vocales[0] = 'a'; //Primer elemento
// vocales[1] = 'e'; //Segundo elemento
// vocales[2] = 'i'; //Tercer elemento
// vocales[3] = 'o'; //Cuarto elemento
// vocales[4] = 'u'; //Quinto elemento

// var cuartaVocal = vocales[3];

// Console.WriteLine(cuartaVocal);

// // Arreglos bidimensional

// int[,] matriz = new int[2, 2];

// matriz[0, 0] = 1;
// matriz[0, 1] = 2;
// matriz[1, 0] = 3;
// matriz[1, 1] = 4;

// var elemento01 = matriz[0,1];

// Console.WriteLine(elemento01);

// int[,] matriz2 = new int[,]
// {
//     {5,6,0}, //Primera fila
//     {7,8,-3}, // Segunda fila
//     {2,-4,55} // Tercera fila
// };

// for(int fila = 0; fila < matriz2.GetLength(0); fila++){
//     for (int i = 0; i < matriz2.GetLength(1); i++)
//     {
//         Console.Write($"{matriz2[fila, i]} ");
//     }
//     Console.WriteLine();
// }

// // Arreglos de arreglos

int[][] arregloDeArreglos =
{
    new int[]{1 , 2},
    new int[]{3 , 4 , 5},
    new int[]{6},
    new int[]{7 , 8}
};

var segundoElemento = arregloDeArreglos[1];

// foreach (var valoe in segundoElemento)
// {
//     Console.Write($"{valoe} ");
// }

for (int filas = 0; filas < arregloDeArreglos.Length; filas++)
{
    var arreglo = arregloDeArreglos[filas];
    for (int columna = 0; columna < arreglo.Length; columna++)
    {
        Console.Write($"{arreglo[columna]} ");
    }
    Console.WriteLine();
}