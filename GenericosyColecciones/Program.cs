using GenericosYColecciones;


int[] enteros = { 2, 3, 4};

string[] nombres = { "Enrique", "Desirée", "Juan", "Alejandra" };

DateTime[] fechas = {DateTime.Today, DateTime.Today.AddDays(1)};

Console.WriteLine($"Longitud de arreglo de enteros {CalcularLongitudDeArreglo(enteros)}");

Console.WriteLine($"Longitud de arreglo de nombres {CalcularLongitudDeArreglo(nombres)}");


Console.WriteLine($"Longitud de arreglo de fechas {CalcularLongitudDeArreglo(fechas)}");

Console.WriteLine();

Console.WriteLine($"Primer elemnto del arreglo de enteros {PrimerElementoOValorPorDefecto(enteros)}");

Console.WriteLine($"Primer elemnto del arreglo de nombre {PrimerElementoOValorPorDefecto(nombres)}");

Console.WriteLine($"Primer elemnto del arreglo de fechas {PrimerElementoOValorPorDefecto(fechas)}");

int CalcularLongitudDeArreglo<T>(T[] arreglo)
{
    return arreglo.Length;
}

T? PrimerElementoOValorPorDefecto<T>(T[] arreglo)
{
    if (arreglo.Length == 0)
    {
        return default; 
    }
    return arreglo[0];
}



List<int> enterosLista = new List<int>();
enterosLista.Add(1);
enterosLista.Add(5);
enterosLista.Add(15);

List<int> enterosLista2 = new() { 1, 5, 15 };

enterosLista2.Add(-8);

Console.WriteLine();

Dictionary<string, int> diccionario = new Dictionary<string, int>();
diccionario.Add("Uno", 1); // // Solamente agregar
diccionario["Dos"] = 2; // // Agregar y modificar valores

var diccionario2 = new Dictionary<string, int>()
{
    {"Uno", 1},
    {"Dos", 2},
    {"Tres", 3},
};

Console.WriteLine(diccionario["Dos"]);

if (diccionario.ContainsKey("Tres"))
{
    Console.WriteLine(diccionario["Tres"]);
}
else
{
    Console.WriteLine("La llave no fue encontrada");
}

var diccionariParImpar = new Dictionary<string, List<int>>();
diccionariParImpar.Add("par", new List<int>());
diccionariParImpar.Add("impar", new List<int>());

for (int i = 1; i <= 10; i++)
{
    var llave = i % 2 == 0 ? "par" : "impar";
    diccionariParImpar[llave].Add(i);
}

foreach (var llaveValores in diccionariParImpar)
{
    Console.WriteLine(llaveValores.Key);
    foreach (var valor in llaveValores.Value)
    {
        Console.WriteLine($"- {valor}");
    }
}

IEnumerable<int> conElValor2 = Sumar2(2).Take(30);

foreach (var valor in conElValor2)
{
    Console.WriteLine(valor);
}
IEnumerable<int> Sumar2(int valor)
{
    yield return valor;
    for (;;)
    {
        valor += 2;
        yield return valor;
    }
}

var Enrique = new Persona {Nombre1 = "Enrique", Edad1 = 23};
var Desirée = new Persona {Nombre1 = "Desirée", Edad1 = 21};

var valor1 = Enrique.CompareTo(Desirée);
Console.WriteLine(valor1);

var personas = new List<Persona>()
{
    Desirée,
    new Persona(){Nombre1 = "Julio", Edad1 = 14},
    new Persona(){Nombre1 = "Abraham", Edad1 = 34},
    new Persona(){Nombre1 = "Luisa", Edad1 = 22},
    Enrique,
    new Persona(){Nombre1 = "Maria", Edad1 = 34},
};

personas.Sort();

Console.WriteLine("Ordenando por edad: ");

foreach (var persona1 in personas)
{
    Console.WriteLine($"- {persona1.Nombre1} (Edad: {persona1.Edad1})");
}

// // Ordenando por nombre

personas.Sort(new CompararandoPersonas());

Console.WriteLine();

Console.WriteLine("Ordenando por Nombre: ");

foreach (var persona1 in personas)
{
    Console.WriteLine($"- {persona1.Nombre1} (Edad: {persona1.Edad1})");
}
