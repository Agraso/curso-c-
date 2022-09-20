using ModuloLinQ;

int[] numeros = Enumerable.Range(1, 20).ToArray();


// Esto es LinQ (sinteaxis de metodos)
var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

// // Forma 2: Sintaxis de queries
var numerosPares1 = (from n in numeros
                        where n % 2 == 0
                        select n).ToList();

var numerosImpares = numeros.Where(n => n % 2 == 1 ).ToList();

var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

// Ejemplo 2: Coleccion de objetos

var personas = new List<Persona>(){
  new Persona { Nombre = "Enrique", Edad = 40, FechaIngresoALaEmpresa = new DateTime(2021, 2, 15), Soltero = true },
  new Persona { Nombre = "Naida", Edad = 25, FechaIngresoALaEmpresa = new DateTime(2015, 10, 22), Soltero = true},
  new Persona { Nombre = "Jose", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2020, 2, 15), Soltero = false },
  new Persona { Nombre = "Elena", Edad = 61, FechaIngresoALaEmpresa = new DateTime(2020, 5, 3), Soltero = false },
  new Persona { Nombre = "Victor", Edad = 20, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};

var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();

foreach (var persona in personasDe25AñosOMenos)
{
    Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
}

var nombresConOrden = personas.Select((persona, indice) => new {Nombre = persona.Nombre , Orden = indice + 1 }).ToList();

foreach (var item in nombresConOrden)
{
    Console.WriteLine($"{item.Orden}) {item.Nombre}");
}

Console.WriteLine();