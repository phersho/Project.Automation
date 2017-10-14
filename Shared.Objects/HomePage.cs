﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Shared.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Objects
{
    public class HomePage
    {
        #region Web Elements and class attributes

        // Class Attributes
        public SharedFunctions sharedFunctions;

        // Web Elements
        [FindsBy(How = How.Id, Using = "spinner")]
        public IWebElement spinner { get; set; }

        #endregion

        // Constructor
        public HomePage(IWebDriver Driver)
        {
            PageFactory.InitElements(Driver, this);
            ImplicitWait implicitWait = new ImplicitWait(Driver);
            sharedFunctions = new SharedFunctions();
        }

        #region Possible actions
        
        #endregion

    }
}