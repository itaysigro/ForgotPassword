using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;
using System.Threading;

namespace ForgotPassword
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a driver instance for chromedriver
            IWebDriver driver = new ChromeDriver();

            //Navigate to google page
            driver.Navigate().GoToUrl("https://www.inn.co.il/Forum/");
           

            //Maximize the window
            driver.Manage().Window.Maximize();

            var login1 = driver.FindElement(By.CssSelector("#TopMiddleLinksUser > span > b"));
            login1.Click();
            Thread.Sleep(1000);

            var UserName = driver.FindElement(By.CssSelector("input[name='username']"));
            UserName.SendKeys("itays");
            Thread.Sleep(1000);

            var Pass = driver.FindElement(By.CssSelector("input[name='password']"));
            Pass.SendKeys("123");
            Thread.Sleep(1000);

            var log = driver.FindElement(By.CssSelector("body > div.GenericWindow.NoShadow > div.Login > form > div > input"));
            log.Click();
            Thread.Sleep(10000);

            var ForgetPass = driver.FindElement(By.CssSelector("body > div.GenericWindow.NoShadow > div.Login > div.reg > a:nth-child(4)"));
            ForgetPass.Click();
            Thread.Sleep(2000);

            var input = driver.FindElement(By.CssSelector("#q"));
            input.SendKeys("blabla");
            Thread.Sleep(3000);

            var ForgetUserName = driver.FindElement(By.XPath("//*[@id='Forgot1']/table/tbody/tr[1]/td[2]/input"));
            ForgetUserName.Click();
            ForgetUserName.SendKeys("itays");
            Thread.Sleep(1000);

            var ForgetEmail = driver.FindElement(By.CssSelector("input[name='email']"));
            ForgetEmail.SendKeys("itaysigroni1@walla.co.il");
            Thread.Sleep(1000);

            var Submit = driver.FindElement(By.CssSelector("#Forgot1 > table > tbody > tr:nth-child(3) > td:nth-child(2) > button"));
            Submit.Click();


            //open new tab
             ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
             driver.SwitchTo().Window(driver.WindowHandles.Last());
             driver.Navigate().GoToUrl("http:www.walla.co.il");
             Thread.Sleep(5000);


             var Email3 = driver.FindElement(By.CssSelector("#root > div > div > header > div.first-row > div > div.promotions.no-mobile > div.promo.mail > a > div:nth-child(2) > div.line-1"));
             Email3.Click();
             Thread.Sleep(6000);

             var UserName1 = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > ul > li.required-field > app-input-user-name > form > input"));
             UserName1.SendKeys("itaysigroni1");

             var Next = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > ul > li:nth-child(3) > button"));
             Next.Click();
             Thread.Sleep(2000);

             var Pass1 = driver.FindElement(By.CssSelector(".label-input, input[type=email], input[type=number], input[type=password], input[type=search], input[type=tel], input[type=text], input[type=url], select, textarea"));
             Pass1.SendKeys("A1357911a*");
             Thread.Sleep(2000);

             var Next1 = driver.FindElement(By.CssSelector("#wrapper > section > form > fieldset > button.common-button-1.full-line"));
             Next1.Click();
             Thread.Sleep(6000);

             var OpenMaill1 = driver.FindElement(By.CssSelector("#main-content > div > div.mail-list-wrap.mail-list-inf > div.mail-list > ul > li:nth-child(2) > div.cell.sender > span"));
             OpenMaill1.Click();
             Thread.Sleep(7000);

             var ChangePassword = driver.FindElement(By.CssSelector("#mailContent > div > div:nth-child(3) > a:nth-child(6)"));
             ChangePassword.Click();
             Thread.Sleep(4500);

             ((IJavaScriptExecutor)driver).ExecuteScript("window.close();");
             driver.SwitchTo().Window(driver.WindowHandles.Last());
             Thread.Sleep(5000);

             var input1 = driver.FindElement(By.CssSelector("#q"));
             input1.SendKeys("blabla");
             Thread.Sleep(3000);

             var ChangePass = driver.FindElement(By.CssSelector("input[name='password1']"));
             ChangePass.SendKeys("123456");

             var ChangePass1 = driver.FindElement(By.CssSelector("input[name='password2']"));
             ChangePass1.SendKeys("123456");

             var Sub = driver.FindElement(By.CssSelector("#Forgot2 > table > tbody > tr:nth-child(3) > td:nth-child(2) > button"));
             Sub.Click();
             Thread.Sleep(3000);

            var login2 = driver.FindElement(By.CssSelector("#TopMiddleLinksUser > span > b"));
            login2.Click();
            Thread.Sleep(3000);

            var UserName5 = driver.FindElement(By.CssSelector("input[name='username']"));
            UserName5.SendKeys("itays");
            Thread.Sleep(1000);

            var Pass3 = driver.FindElement(By.CssSelector("input[name='password']"));
            Pass3.SendKeys("123456");
            Thread.Sleep(3000);

            var log3 = driver.FindElement(By.CssSelector("body > div.GenericWindow.NoShadow > div.Login > form > div > input"));
            log3.Click();
            Thread.Sleep(3000);
        }
    }
}
