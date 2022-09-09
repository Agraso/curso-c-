using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Carros
    {
        internal Carros(): this("marca por defecto")
        {
            Console.WriteLine("Instanciando un carro");
        }
        internal Carros(string marca)
        {
            Console.WriteLine("Instanciando un carro con una marca");
            _marca = marca;
            ConteoInstancias++;
        }
        public static int ConteoInstancias {get; set; }
        private string _marca;

        internal string Marca
        {
            get {return _marca.ToUpper(); }
            set {_marca = value; }
        }
        internal int _año {get; set; } = 1990;

        internal int Velocidad { get; private set; } = 20;
        internal string NombreComercial => $"{Marca} ({_año})";

        internal void Acelerar()
        {
            if (Velocidad >= 120)
            {
                Console.WriteLine("La velocidad maxima ya ha sido alcanzada");
                return;
            }
                Velocidad++;
        }

        internal void Detener() => Velocidad = 0;
    }
}