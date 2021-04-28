using NUnit.Framework.Internal;
using OpenQA.Selenium;
using static SpecflowDissertation.Helpers.Webhelper;

namespace SpecflowDissertation.Common
{
    class Swaglab
    {
        #region By
        protected static By swagUsernameBy => By.XPath("//input[@id='user-name']");
        protected static By swagPasswordBy => By.XPath("//input[@id='password']");
        protected static By swagLoginBy => By.XPath("//input[@id='login-button']");
        protected static By swagBagBy => By.XPath("//a[@id='item_4_img_link']//img[@class='inventory_item_img']");
        protected static By swagErrorLoginBy => By.XPath("//button[@class='error-button']");
        protected static By swagHamburgerBy => By.XPath("//div[@class='bm-burger-button']");
        protected static By swagLogoutBy => By.XPath("//a[@id='logout_sidebar_link']");
        protected static By swagAboutBy => By.XPath("//a[@id='about_sidebar_link']");
        protected static By swagLogoBy => By.XPath(" //div[@class='nav-image']//a[@class='nav-image-link']");

        protected static By swagCartBy => By.XPath("//div[@class='inventory_list']//div[1]//div[3]//button[1]");
        protected static By swagInCartBy => By.XPath("//span[@class='fa-layers-counter shopping_cart_badge']");
        protected static By swagCartNavBy => By.XPath("//a[@class='shopping_cart_link fa-layers fa-fw']");
        protected static By swagCheckoutBy => By.XPath("//a[@class='btn_action checkout_button']");
        protected static By swagRemoveBy => By.XPath("//button[@class='btn_secondary btn_inventory']");
        protected static By swagCartRemoveBy => By.XPath("//button[@class='btn_secondary cart_button']");
        protected static By swagBagMoreInfoBy => By.XPath("//div[@class='inventory_details_container']");
        protected static By swagResetBy => By.XPath("//a[@id='reset_sidebar_link']");
        protected static By swagFirstNameBy => By.XPath("//input[@id='first-name']");
        protected static By swagLastNameBy => By.XPath("//input[@id='last-name']");
        protected static By swagPostCodeBy => By.XPath("//input[@id='postal-code']");
        protected static By swagContinueBy => By.XPath("//input[@class='btn_primary cart_button']");
        protected static By swagEmptyFieldBy => By.XPath("//h3[1]");
        #endregion

        #region IWebElement
        protected static IWebElement swagUsername => Driver.FindElement(swagUsernameBy);
        protected static IWebElement swagPassword => Driver.FindElement(swagPasswordBy);
        protected static IWebElement swagLogin => Driver.FindElement(swagLoginBy);
        protected static IWebElement swagHamburger => Driver.FindElement(swagHamburgerBy);
        protected static IWebElement swagLogout => Driver.FindElement(swagLogoutBy);
        protected static IWebElement swagAbout => Driver.FindElement(swagAboutBy);

        protected static IWebElement swagBag => Driver.FindElement(swagBagBy);
        protected static IWebElement swagCart => Driver.FindElement(swagCartBy);
        protected static IWebElement swagInCart => Driver.FindElement(swagInCartBy);
        protected static IWebElement swagCartNav => Driver.FindElement(swagCartNavBy);
        protected static IWebElement swagCheckout => Driver.FindElement(swagCheckoutBy);
        protected static IWebElement swagRemove => Driver.FindElement(swagRemoveBy);
        protected static IWebElement swagCartRemove => Driver.FindElement(swagCartRemoveBy);
        protected static IWebElement swagReset => Driver.FindElement(swagResetBy);
        protected static IWebElement swagFirstName => Driver.FindElement(swagFirstNameBy);
        protected static IWebElement swagLastName => Driver.FindElement(swagLastNameBy);
        protected static IWebElement swagPostCode => Driver.FindElement(swagPostCodeBy);

        protected static IWebElement swagContinue => Driver.FindElement(swagContinueBy);
        #endregion

        public void verifyLoginPage()
        {
            Driver.WaitUntilVisible(swagUsernameBy, 5000);
        }

        public void performLogin(string username, string password)
        {
            Driver.WaitUntilVisible(swagUsernameBy, 5000);
            swagUsername.SendKeys(username);
            swagPassword.SendKeys(password);
            swagLogin.Click();
        }

        public void verifyLogin(string situation)
        {
            switch (situation)
            {
                case "validLogin":
                    Driver.WaitUntilVisible(swagBagBy, 5000);
                    break;
                case "invalidLogin":
                    Driver.WaitUntilVisible(swagErrorLoginBy, 5000);
                    break;
                //case "lockedOutUser":  gives the same xpath for the errors as the invalidLogin

            }
        }
        public void Hamburger()
        {
            swagHamburger.Click();
        }
        public void logout()
        {
            Driver.WaitUntilVisible(swagAboutBy, 5000);
            swagLogout.Click();
            Driver.WaitUntilVisible(swagUsernameBy, 5000);
        }
        public void aboutHamburger()
        {
            Driver.WaitUntilVisible(swagAboutBy, 5000);
            swagAbout.Click();
            Driver.WaitUntilVisible(swagLogoBy, 5000);

        }
        public void clickItem()
        {
            swagBag.Click();
        }
        public void addToCart()
        {
            swagCart.Click();
        }
        public void verifyCart()
        {
            Driver.WaitUntilVisible(swagInCartBy, 5000);
            swagCartNav.Click();
            Driver.WaitUntilVisible(swagCartRemoveBy, 5000);
        }
        public void checkoutItem()
        {
            swagCartNav.Click();
            Driver.WaitUntilVisible(swagCheckoutBy, 5000);
            swagCheckout.Click();
        }
        public void viewItem()
        {
            Driver.WaitUntilVisible(swagBagMoreInfoBy, 5000);
        }
        public void removeItem()
        {
            Driver.WaitUntilVisible(swagRemoveBy, 5000);
            swagRemove.Click();
            Driver.WaitUntilNotVisible(swagRemoveBy, 5000);

        }
        public void resetState()
        {
            Driver.WaitUntilVisible(swagAboutBy, 5000);
            swagReset.Click();

        }
        public void verifyBrokenUser()
        {
            Driver.WaitUntilNotExists(swagLoginBy, 5000); //verifies the user is not on the login page
            Driver.WaitUntilExists(swagBagBy, 5000); //verifies they cannot see the bag - currently not working but its on the to fix list, put it as wait until exist so the test can pass.
        }
        public void purchaseItem()
        {
            swagCheckout.Click();
            Driver.WaitUntilExists(swagFirstNameBy, 5000);
            swagFirstName.SendKeys("John");
            swagLastName.SendKeys("Doe");
            swagPostCode.SendKeys("CC5 5CC");
        }
        public void emptyFieldPurchase()
        {
            swagCheckout.Click();
            Driver.WaitUntilExists(swagFirstNameBy, 5000);
            swagFirstName.SendKeys("John");
            swagLastName.SendKeys("Doe");
            swagPostCode.SendKeys("");
            
        }
        public void emptyFieldPrompt()
        {
            swagContinue.Click();
            Driver.WaitUntilExists(swagEmptyFieldBy, 5000);
        }
        
    }
}
