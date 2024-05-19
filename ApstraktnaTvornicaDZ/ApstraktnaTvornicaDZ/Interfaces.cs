using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnaTvornicaDZ
{
    public class Interfaces
    {
        public interface IWizard
        {
            void DoMagic();
        }

        public interface IGoblin
        {
            void DoDamage();
        }

        public interface IFactory
        {
            IWizard CreateWizard();
            IGoblin CreateGoblin();
        }

    }
}
