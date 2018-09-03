using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjectSeleniumModified.POM
{
    public class CheckOut
    {
        [Obsolete("Use newMethod instead", false)]
        //empty constructor
        public CheckOut()
        {
            Console.WriteLine("Inside Constructor : Checkout");
            PageFactory.InitElements(PropertiesCollection.driver, this);

        }
        [FindsBy(How = How.ClassName, Using = "standard-checkout")]
        public IWebElement CheckOutButton { get; set; }

        public void CompleteTransaction()
        {

            Console.WriteLine("Inside CompleteTransaction");
            Console.WriteLine(CheckOutButton);
            CheckOutButton.Click();
            //for page reload
            //Console.WriteLine(CheckOutButton);
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("After First Click and Sleep");
            CheckOutButton = PropertiesCollection.driver.FindElement(By.Name("processAddress"));
            Console.WriteLine(CheckOutButton);
            CheckOutButton.Click();
        }
    }
}
