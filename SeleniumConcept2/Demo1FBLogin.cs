using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo1FBLogin
    {
        static void Main(string[]args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.facebook.com/";

            driver.FindElement(By.Id("email")).SendKeys("wrongemail@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("123123123");
            driver.FindElement(By.Id("loginbutton")).Click();


            //driver.Quit();
        }
    }
}
