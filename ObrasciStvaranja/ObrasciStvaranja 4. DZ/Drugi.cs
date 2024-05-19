using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrasciStvaranja_4._DZ
{
    public class Drugi
    {

        /* OBRAZAC STVARANJA METODA TVORNICA */
        public class WebElement
        {
            private string name;

            public WebElement(string name)
            {
                Console.WriteLine($"Found {name}");
                this.name = name;
            }

            public void Click()
            {
                Console.WriteLine($"Clicked {name}");
            }
        }

        public abstract class LoginPageFactory
        {
            public abstract WebElement CreateLoginButton();
            public abstract WebElement CreateUsernameInput();
            public abstract WebElement CreatePasswordInput();
        }

        public class ChromeLoginPageFactory : LoginPageFactory
        {
            public override WebElement CreateLoginButton()
            {
                return new WebElement("Chrome Login Button");
            }

            public override WebElement CreateUsernameInput()
            {
                return new WebElement("Chrome Username Input");
            }

            public override WebElement CreatePasswordInput()
            {
                return new WebElement("Chrome Password Input");
            }
        }
    }
}
