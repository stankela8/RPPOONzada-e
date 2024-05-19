using static ObrasciStvaranja_4._DZ.Drugi;
using static ObrasciStvaranja_4._DZ.Prvi;

public class Program
{
    public static void Main(string[] args)
    {
        //Prvi
        IMailConstructor mailConstructor = new MailConstructor();
        SMTP smtp = new SMTP(mailConstructor);
        smtp.SendNoReplyMail();

        //Drugi
        LoginPageFactory factory = new ChromeLoginPageFactory();

        WebElement loginButton = factory.CreateLoginButton();
        WebElement usernameInput = factory.CreateUsernameInput();
        WebElement passwordInput = factory.CreatePasswordInput();

        usernameInput.Click();
        passwordInput.Click();
        loginButton.Click();
    }
}
