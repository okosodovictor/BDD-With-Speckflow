using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDSample.specs
{
      [Binding]
      public class Environment
        {
            private static ChromeDriver driver;

            public static IWebDriver Driver
            {
                get { return driver ?? (driver = new ChromeDriver(@"C:\Projects\BDDSample\ChromeDriver")); }
            }

            [AfterTestRun]
            public static void AfterTestRun()
            {
                Driver.Close();
                Driver.Quit();
                driver = null;
            }
    }
}
