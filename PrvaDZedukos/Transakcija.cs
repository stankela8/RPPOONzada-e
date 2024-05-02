using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaDZedukos
{
    public abstract class Transakcija : ITransakcija
    {
        public decimal Iznos { get; set; }
        public abstract void IzvršiTransakciju();
    }
}
