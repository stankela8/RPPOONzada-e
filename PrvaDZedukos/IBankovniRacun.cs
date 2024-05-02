using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaDZedukos
{
    public interface IBankovniRacun
    {
        void Uplati(decimal amount);
        void Isplati(decimal amount);
    }
}
