using NUnit.Framework.Internal;
using OpenQA.Selenium;
using static SpecflowDissertation.Helpers.Webhelper;

namespace SpecflowDissertation.Common
{
    class Comp 
    {

        /* 
        ##############################################################
        this is one method of writing specflow tests, by seperating the clicks,
        the waitfor and the sendkeys it is easier to seperate each task from each other
        
        one of the issues of using this method is that you would need to find which
        parts belong to which test which can be an issue in the long term once you get to
        100+ tests and/or multiple products.
        ##############################################################
        */

        #region Css
        //protected static readonly string insideToggleStr = "body.page-template-default.page.page-id-579.et_color_scheme_green.et_button_custom_icon.et_pb_button_helper_class.et_fixed_nav.et_show_nav.et_hide_mobile_logo.et_primary_nav_dropdown_animation_expand.et_secondary_nav_dropdown_animation_fade.et_header_style_left.et_pb_footer_columns4.et_cover_background.et_pb_gutter.osx.et_pb_gutters2.et_pb_pagebuilder_layout.et_no_sidebar.et_divi_theme.et-db.et_minified_js.et_minified_css.chrome:nth-child(2) div.et-animated-content:nth-child(1) article.post-579.page.type-page.status-publish.hentry div.entry-content div.et-boc div.et-l.et-l--post div.et_builder_inner_content.et_pb_gutters3 div.et_pb_section.et_pb_section_0.et_section_regular:nth-child(1) div.et_pb_row.et_pb_row_6.et_pb_row_1-4_1-2_1-4:nth-child(7) div.et_pb_column.et_pb_column_1_2.et_pb_column_11.et_pb_css_mix_blend_mode_passthrough:nth-child(2) div.et_pb_module.et_pb_toggle.et_pb_toggle_0.et_pb_toggle_item.et_pb_toggle_open:nth-child(3) > h5.et_pb_toggle_title";
        protected static readonly string insideToggleStr = "body.page-template-default.page.page-id-579.et_color_scheme_green.et_button_custom_icon.et_pb_button_helper_class.et_fixed_nav.et_show_nav.et_hide_mobile_logo.et_primary_nav_dropdown_animation_expand.et_secondary_nav_dropdown_animation_fade.et_header_style_left.et_pb_footer_columns4.et_cover_background.et_pb_gutter.windows.et_pb_gutters2.et_pb_pagebuilder_layout.et_no_sidebar.et_divi_theme.et-db.et_minified_js.et_minified_css.chrome:nth-child(2) div.et-animated-content:nth-child(1) article.post-579.page.type-page.status-publish.hentry div.entry-content div.et-boc div.et-l.et-l--post div.et_builder_inner_content.et_pb_gutters3 div.et_pb_section.et_pb_section_0.et_section_regular:nth-child(1) div.et_pb_row.et_pb_row_6.et_pb_row_1-4_1-2_1-4:nth-child(7) div.et_pb_column.et_pb_column_1_2.et_pb_column_11.et_pb_css_mix_blend_mode_passthrough:nth-child(2) div.et_pb_module.et_pb_toggle.et_pb_toggle_0.et_pb_toggle_item.et_pb_toggle_open:nth-child(3) > div.et_pb_toggle_content.clearfix";
        protected static By insideToggleCss => By.CssSelector(insideToggleStr);
        #endregion

        #region By

        #region navTask
        protected static By skillsImprBy => By.XPath("//span[@id='Skills_Improved']");
        #endregion

        #region buttonsTask
        protected static By buttonOneFromSelectBy => By.XPath("//a[@class='et_pb_button et_pb_button_0 et_pb_bg_layout_light']");
        protected static By selectionOfButtonsBy => By.XPath("//span[@id='Section_of_Buttons']");
        protected static By socialLinksSidebarBy => By.XPath("//div[@class='swp_social_panelSide swp_floating_panel swp_social_panel swp_boxed swp_default_full_color swp_other_full_color swp_individual_full_color slide swp_float_left swp_side_center scale-100 float-position-center-left']");
        #endregion

        #region twitterTask
        protected static By twitterButtonBy => By.XPath("//li[@class='et_pb_social_media_follow_network_0 et_pb_social_icon et_pb_social_network_link et-social-twitter et_pb_social_media_follow_network_0']//a[@class='icon et_pb_with_border']");
        protected static By twitterAccountImageBy => By.XPath("//a[@class='css-4rbku5 css-18t94o4 css-1dbjc4n r-14lw9ot r-11mg6pl r-sdzlij r-1phboty r-14f9gny r-1loqt21 r-1gzrgec r-cnkkqs r-zjg7tu r-mtrfb5 r-1ny4l3l r-1udh08x r-o7ynqc r-6416eg r-1xce0ei']//div[@class='css-1dbjc4n r-1twgtwe r-sdzlij r-rs99b7 r-1p0dtai r-1mi75qu r-1d2f490 r-1ny4l3l r-u8s1d r-zchlnj r-ipm5af r-o7ynqc r-6416eg']");
        #endregion

        #region facebookTask
        protected static By facebookButtonBy => By.XPath("//li[@class='et_pb_social_media_follow_network_1 et_pb_social_icon et_pb_social_network_link et-social-facebook et_pb_social_media_follow_network_1']//a[@class='icon et_pb_with_border']");
        protected static By facebookAccountImageBy => By.XPath("//img[@class='_6tb5 img']");
        #endregion

        #region toggleTask
        protected static By aToggleBy => By.XPath("//div[@class='et_pb_module et_pb_toggle et_pb_toggle_0 et_pb_toggle_item et_pb_toggle_close']");
        #endregion

        #region likeThisTask
        protected static By likeThisBy => By.XPath("//div[@class='et_pb_column et_pb_column_1_4 et_pb_column_10 et_pb_css_mix_blend_mode_passthrough']//div[5]//div[1]//div[1]//a[1]");
        protected static By loadingBy => By.XPath("//span[@class='loading']");
        #endregion

        #region ClickableFooterTask
        //protected static By footersClickableSearchBy => By.XPath("//div[@class='et_pb_module et_pb_sidebar_0 et_pb_widget_area clearfix et_pb_widget_area_left et_pb_bg_layout_light']//a[@class='jetpack-search-filter__link'][contains(text(),'Footers (1)')]");
        protected static By footersClickableSearchBy => By.XPath("//div[@class='et_pb_module et_pb_sidebar_0 et_pb_widget_area clearfix et_pb_widget_area_left et_pb_bg_layout_light']//a[@class='jetpack-search-filter__link'][contains(text(),'Post (213)')]");
        protected static By searchResultIsComplicatedPageBy => By.XPath("//a[contains(text(),'Complicated Page')]");
        #endregion

        #region SearchSpecificTask
        protected static By compPageSearchbarBy => By.XPath("//div[@class='et_pb_module et_pb_sidebar_0 et_pb_widget_area clearfix et_pb_widget_area_left et_pb_bg_layout_light']//div[@id='jetpack-search-filters-1']//div[@id='jetpack-search-filters-1-wrapper']//div[@class='jetpack-search-form']//form[@id='searchform']//div//input[@id='s']");
        protected static By compActualSearchBarBy => By.XPath("//input[@id='jetpack-instant-search__box-input-1']");
        protected static By compPageSearchBarResultOneBy => By.XPath("//li[1]//h3[1]//a[1]");
        #endregion

        #region SearchIncorrectTask
        protected static By compPageSearchBarNoResultBy => By.XPath("//div[@class='jetpack-instant-search__search-results-title']");
        #endregion


        #endregion

        #region IWebElement
        protected static IWebElement buttonOneFromSelect => Driver.FindElement(buttonOneFromSelectBy);
        protected static IWebElement twitterButton => Driver.FindElement(twitterButtonBy);
        protected static IWebElement facebookButton => Driver.FindElement(facebookButtonBy);
        protected static IWebElement aToggle => Driver.FindElement(aToggleBy);
        protected static IWebElement likeThis => Driver.FindElement(likeThisBy);
        protected static IWebElement footersClickableSearch => Driver.FindElement(footersClickableSearchBy);
        protected static IWebElement compPageSearchbar => Driver.FindElement(compPageSearchbarBy);
        protected static IWebElement compActualSearchBar => Driver.FindElement(compActualSearchBarBy);

        #endregion

        #region previous obsolete code
        /*
        #############################################################################################
        keeping this section here to show how each addition would require a new public void set up for it,
        both for the pressing of the button, and for the wait until exist, hence why i chose to use the 
        buttonSelector and waitForSelector class instead.
        #############################################################################################
        
        public void verifyCompPage()
        {
            Driver.WaitUntilVisible(selectionOfButtonsBy, 5000);
        }
        
        public void pushButtonOne()
        {
            buttonOneFromSelect.Click();
        }
        public void waitForReappearSidebar()
        {
            Driver.WaitUntilNotExists(socialLinksSidebarBy, 5000);
        }
        public void pushTwitterButton()
        {
            twitterButton.Click();
        }
        public void waitForTwitterAppear()
        {
            Driver.WaitUntilVisible(twitterAccountImageBy, 5000);
        }
        public void pushFacebookButton()
        {
            facebookButton.Click();
        }
        public void waitForFacebookAppear()
        {
            Driver.WaitUntilVisible(facebookAccountImageBy, 5000); 
        }
        */
        #endregion
            /*
        public void testComplete()
        {
            endTest();
        }*/

        public void buttonSelector(string Button)
        {
            
            switch(Button)
            {
                case "ButtonOne":
                    buttonOneFromSelect.Click();
                    break;
                case "Twitter":
                    twitterButton.Click();
                    break;
                case "Facebook":
                    facebookButton.Click();
                    break;
                case "Toggle":
                    aToggle.Click();
                    break;
                case "LikeThis":
                    likeThis.Click();
                    break;
                case "ClickFooters":
                    footersClickableSearch.Click();
                    break;
                case "ClickSearch":
                    compPageSearchbar.Click();
                    break;

            }
        }
        public void waitForSelector(string Element)
        {
            switch (Element)
            {
                case "CompPage":
                    Driver.WaitUntilVisible(selectionOfButtonsBy, 5000);
                    break;
                case "Sidebar":
                    Driver.WaitUntilNotExists(socialLinksSidebarBy, 5000);
                    break;
                case "Twitter":
                    Driver.WaitUntilVisible(twitterAccountImageBy, 5000);
                    break;
                case "Facebook":
                    Driver.WaitUntilVisible(facebookAccountImageBy, 5000);
                    break;
                case "Toggle":
                    Driver.WaitUntilVisible(insideToggleCss, 5000);
                    break;
                case "LikeThis":
                    Driver.WaitUntilVisible(loadingBy, 5000);
                    break;
                case "ClickFooters":
                    Driver.WaitUntilVisible(compActualSearchBarBy, 5000);
                    //Driver.WaitUntilVisible(searchResultIsComplicatedPageBy, 5000);
                    break;
                case "ClickSearch":
                    Driver.WaitUntilVisible(compActualSearchBarBy, 5000);
                    break;
                case "CorrectResults":
                    Driver.WaitUntilVisible(compPageSearchBarResultOneBy, 5000);
                    break;
                case "IncorrectResults":
                    Driver.WaitUntilNotExists(compPageSearchBarResultOneBy, 5000);
                    break;
            }
        }
        public void enterKeysSelector(string Keys, string SearchWord)
        {
            switch (Keys)
            {
                case "ClickSearch":
                    compActualSearchBar.SendKeys(SearchWord);
                    break;
                case "IncorrectSearch":
                    compActualSearchBar.SendKeys(SearchWord);
                    break;
            }
                
                    
        }
    }
}
