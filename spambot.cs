using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace DiscordSpambot
{
    class spambot
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            Console.WriteLine("started");
            driver.Navigate().GoToUrl("https://discord.com/login");
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/form/div/div/div[1]/div[3]/div[1]/div/input")).SendKeys("put email here");
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/form/div/div/div[1]/div[3]/div[2]/div/input")).SendKeys("put password here");
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/form/div/div/div[1]/div[3]/button[2]")).Click();

            System.Threading.Thread.Sleep(14000);
            driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/div/div[2]/div[1]/nav/div[2]/div/a[3]/div")).Click();
            IWebElement text = driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div/div/div[2]/div[2]/div/main/form/div/div/div/div[3]/div[2]"));

            Console.WriteLine("enter text");
            string spam = Console.ReadLine();
            Console.WriteLine("enter spam speed");
            Console.WriteLine("note: anything under 800 may break it");
            int speed = Convert.ToInt32(Console.ReadLine());

            bool yes = true;
            while (yes)
            {

                Console.WriteLine("press escape key to stop");
                text.SendKeys(spam);
                text.SendKeys(Keys.Enter);
                System.Threading.Thread.Sleep(speed);

                if (Console.KeyAvailable && Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    break;
                }

            }
            Environment.Exit(0);
            driver.Close();
            Console.WriteLine("end of program");
            
        }
    }
}
