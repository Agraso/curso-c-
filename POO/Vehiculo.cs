using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class Vehiculo
    {
        public string? Marca { get; set; }
        public int AñoCreacion { get; set; }

        public virtual void DarReversa()
        {
            Console.WriteLine("Dando reversa - Implementacion por defecto");
        }

        public abstract void SonarClaxon();
    }

    internal class Carro: Vehiculo
    {

        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo la radio");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("BIP BIP");
        }
    }

    internal class Camion: Vehiculo
    {
        public override void DarReversa()
        {
            base.DarReversa();
            Console.WriteLine("BEEP! BEEP! BEEP!");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("PON POOOOON");
        }
    }

    internal class Bicicleta : Vehiculo
    {
        public override void SonarClaxon()
        {
            Console.WriteLine("TIRIN");
        }
    }
}