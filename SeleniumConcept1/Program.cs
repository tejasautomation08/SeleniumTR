﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string browser = "edge";
            IWebDriver obj;
            //ChromeDriver driver = new ChromeDriver();
            obj = new ChromeDriver();


            obj.Url = "https://www.facebook.com/";

            string actualTitle = obj.Title;
            Console.WriteLine(actualTitle);

            Console.WriteLine(obj.Title);
            Console.WriteLine(obj.Url);

            obj.Quit();



        }
    }
}
