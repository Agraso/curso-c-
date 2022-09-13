using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal interface IMiInterfaz
    {
        void MiMetodo1();
        string MiMetodo2(int param1);
        bool MiPropiedad1 { get; set; }
    }
}