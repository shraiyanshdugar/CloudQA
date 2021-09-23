using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IWebDriver driver = new ChromeDriver("C:\\Users\\ASUS\\Desktop\\");
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            try {
                IWebElement elm = driver.FindElement(By.Id("fname"));
                elm.SendKeys("shraiyansh");
            }
            catch
            {
                driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[2]/input")).SendKeys("Shraiyansh");
            }

            try {
                IWebElement elm1 = driver.FindElement(By.Id("lname"));
                elm1.SendKeys("Dugar");

            }
            catch {
                driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[3]/input")).SendKeys("Dugar");
            }

          
           try
            {
                IWebElement elm2 = driver.FindElement(By.Id("male"));

                elm2.Click();

            }
            catch
            {
                driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[4]/div/input[1]")).Click();
                
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Thread.Sleep(5000);
            driver.Close();
            

        }
    }
}
