using System;
using System.Runtime.InteropServices.ComTypes;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Internal;

namespace webselenium1
{
    class MainProgramPastebin
    {
        static void Main(string[] args)
        {
            //Make sure to watch the console, as it controls everything
            Console.WriteLine("------------Started program!------------");
            IWebDriver driver = new ChromeDriver();

            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Whats the name");
            string name = Console.ReadLine();
            Console.WriteLine("write for me");
            string text = Console.ReadLine();
            Console.WriteLine("Allright, generating...");

            driver.Url = ("https://pastebin.com/");
            System.Threading.Thread.Sleep(150);
            driver.FindElement(By.Id("postform-text")).SendKeys(text);
            System.Threading.Thread.Sleep(150);
            driver.FindElement(By.Id("postform-name")).SendKeys(name);
            System.Threading.Thread.Sleep(150);
            driver.FindElement(By.ClassName("btn")).Click();
            Console.WriteLine("allright, done!");
            System.Threading.Thread.Sleep(1000);
            
            string url = driver.Url;
            Console.WriteLine("The link to your text is here: " + url);
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Download .txt file?");
            Console.WriteLine("(type yes or no)");
            string awnser = Console.ReadLine();
            
            if(awnser == "yes")
            {
                Console.WriteLine("Allright");
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/a[2]")).Click();
                Console.WriteLine("Downloaded!");
            }
            else
            {
                Console.WriteLine("Allright");
            };

            Console.WriteLine("Quit?");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("(type yes or no)");
            string quit = Console.ReadLine();
            
            if(quit == "yes")
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Allright");
                System.Threading.Thread.Sleep(1000);
                driver.Quit();
                Environment.Exit(0);
            }
            else
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Allright, i'll keep the tabs open");
            }

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("------------Finished program!------------");

        }
    }
}
 