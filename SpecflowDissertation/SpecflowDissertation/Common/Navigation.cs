using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SpecflowDissertation.Helpers.Webhelper;


namespace SpecflowDissertation.Common
{
    class Navigation
    {
        //private readonly IObjectContainer _objectContainer;
        public void navToComp()
        {
            OpenBrowser();
            Driver.Navigate().GoToUrl("https://ultimateqa.com/complicated-page/");
        }
        public void navToSWAGLABS()
        {
            OpenBrowser();
            Driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }


    }
}
