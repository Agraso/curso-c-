using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericosYColecciones
{
    internal class Persona: IComparable<Persona>
    {
        public string Nombre1 { get; set; }
        public int Edad1 { get; set; }

        public int CompareTo(Persona? other)
        {
            if (other is null)
            {
                throw new ArgumentNullException(nameof(other));
            }
            // Explicacion: Si el valor es < 0, entonces la persona actual va primero
            // Si el valor es > 0, entonces la persona acutal va de segundo
            // Si el valor es = 0, entonces llevan el mismo nombre

            return this.Edad1 - other.Edad1;
        }
    }
}