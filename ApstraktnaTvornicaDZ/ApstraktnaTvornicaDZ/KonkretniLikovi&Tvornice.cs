using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApstraktnaTvornicaDZ.Interfaces;

namespace ApstraktnaTvornicaDZ
{
    internal class KonkretniLikovi_Tvornice
    {
        public class FireWizard : IWizard
        {
            public void DoMagic()
            {
                Console.WriteLine("Do Fire Magic");
            }
        }

        public class WaterWizard : IWizard
        {
            public void DoMagic()
            {
                Console.WriteLine("Do Water Magic");
            }
        }

        public class FireGoblin : IGoblin
        {
            public void DoDamage()
            {
                Console.WriteLine("Do Fire Damage");
            }
        }

        public class WaterGoblin : IGoblin
        {
            public void DoDamage()
            {
                Console.WriteLine("Do Water Damage");
            }
        }

        public class FireLevelFactory : IFactory
        {
            public IWizard CreateWizard()
            {
                return new FireWizard();
            }

            public IGoblin CreateGoblin()
            {
                return new FireGoblin();
            }
        }

        public class WaterLevelFactory : IFactory
        {
            public IWizard CreateWizard()
            {
                return new WaterWizard();
            }

            public IGoblin CreateGoblin()
            {
                return new WaterGoblin();
            }
        }

    }
}
