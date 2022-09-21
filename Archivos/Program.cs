var contenido = File.ReadAllText(@"/Users/treetop7/Desktop/curso-c#/Archivos/Ejemplo.txt");

Console.WriteLine(contenido);

var lineas = File.ReadAllLines(@"/Users/treetop7/Desktop/curso-c#/Archivos/ejemplo linea.txt");

var ruta = @"/Users/treetop7/Desktop/curso-c#/Archivos/Mi Directorio";

Directory.CreateDirectory(ruta);

var ruta1 = @"/Users/treetop7/Desktop/curso-c#/Archivos/mensaje.txt";
var streamWriter = new StreamWriter(ruta1, append: true);

streamWriter.WriteLine("Buenos Dias");
streamWriter.Write("En esta carta");
streamWriter.WriteLine($"te informo que la hora es {DateTime.Now.ToString("hh:mm:ss")}");
streamWriter.Write("bye");
streamWriter.Dispose();

