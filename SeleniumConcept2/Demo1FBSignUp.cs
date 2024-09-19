using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Url = "https://www.facebook.com/";

        driver.FindElement(By.LinkText("Sign up for Facebook")).Click();
        driver.FindElement(By.Name("firstname")).SendKeys("Walter");
        driver.FindElement(By.Name("lastname")).SendKeys("White");
        driver.FindElement(By.XPath("//input[@value='-1']")).Click();

        SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("day")));
        selectDay.SelectByText("17");

        SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("month")));
        selectDay.SelectByText("Jun");

        SelectElement selectDay = new SelectElement(driver.FindElement(By.Id("year")));
        selectDay.SelectByText("1992");


        //driver.Quit();
    }
}
