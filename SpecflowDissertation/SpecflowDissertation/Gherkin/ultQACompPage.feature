Feature: complicatedPage 

Scenario Outline: Navigating to the website.
    Given I start this test
    Then I should navigate to the Complicated Page website

Scenario Outline: Press the button
    Given I am on the Complicated Page website
    And I press a button
    Then the page should refresh

Scenario Outline: Press Twitter button
    Given I am on the Complicated Page website
    And i press the twitter button
    Then i should be redirected to twitter

Scenario Outline: Press Facebook button
    Given I am on the Complicated Page website
    And i press the facebook button
    Then i should be redirected to facebook

Scenario Outline: Press the Toggle button
    Given I am on the Complicated Page website
    And i press the toggle button
    Then i should see its contents

Scenario Outline: Press Like this to move to the botton of the page
    Given I am on the Complicated Page website
    When i press the Like this button
    Then i should be moved to the bottom of the page

Scenario Outline: Press the Footer Button
    Given I am on the Complicated Page website
    When i press the Footer button underneath the search bar
    Then it would open the search page and show a link to the Complicated page

Scenario Outline: Search for the word "Test"
    Given I am on the Complicated Page website
    When i click on the search bar
    And enter the word "test"
    Then it would search for anything with the word test in it

Scenario Outline: Search for an ambiguous word in order to find no result
    Given I am on the Complicated Page website
    When i click on the search bar
    And i enter the word "ThisIsOnlyHereAsAProofOfConcept"
    Then no results should be found

