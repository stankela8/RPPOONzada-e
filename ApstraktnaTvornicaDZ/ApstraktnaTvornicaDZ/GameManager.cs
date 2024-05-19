using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApstraktnaTvornicaDZ.Interfaces;

namespace ApstraktnaTvornicaDZ
{
    public class GameManager
    {
       
            public IFactory levelFactory;

            public GameManager(IFactory levelFactory)
            {
                this.levelFactory = levelFactory;
            }

            public void PlayLevel()
            {
                IGoblin goblin = levelFactory.CreateGoblin();
                IWizard wizard = levelFactory.CreateWizard();
                goblin.DoDamage();
                wizard.DoMagic();
            }
    }
}
