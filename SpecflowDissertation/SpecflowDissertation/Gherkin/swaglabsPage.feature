Feature:  Swaglabs Page

Scenario Outline: Navigate to the Swaglabs page
	Given i start the swaglabs test
	Then i should automatically navigate to the swaglabs website

Scenario Outline: Login to the Swaglabs page
	Given i start the swaglabs test
	Then i should be able to login with the username "standard_user" and the password "secret_sauce"

Scenario Outline: Login with the Incorrect username
	Given i am on the swaglabs login page
	And i enter the invalid username "test123" and the correct password for all users which is "secret_sauce"
	Then i should not be able to login

Scenario Outline: Login with the Incorret password
	Given i am on the swaglabs login page
	And i enter the username "standard_user" and "NotThePassword" which is an invalid password
	Then i should not be able to login

Scenario Outline: Login with a Locked out user
	Given i am on the swaglabs login page
	And i enter the username "locked_out_user" and the password "secret_sauce"
	Then i should not be able to login as the user is locked out

Scenario Outline: Login with a Problem user
	Given i am on the swaglabs login page
	And i enter the username "problem_user" and the password "secret_sauce"
	Then i should not be able to see any of the product images as this user has a problem

Scenario Outline: Logout of the Swaglabs page
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	Then i should be able to logout

Scenario Outline: View a Specific item
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i click on an item
	Then i should be moved to a page with more information on it

Scenario Outline: Add to Cart on the Swaglabs page
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	Then i should be able to add an item to the kart

Scenario Outline: Remove from cart on the Swaglabs page
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i add an item to my kart
	Then i should be able to remove it

Scenario Outline: View my Swaglabs Kart
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i add an item to my kart
	Then i should be able to view it 

Scenario Outline: Purchase an item
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i add an item to my kart
	Then i should be able to purchase it

Scenario Outline: Leave a blank field during checkout
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i have an item in my kart
	And i go to check it out
	When i have an empty field
	Then i should be prompted that it is empty

Scenario Outline: Reset App State
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	And i add an item to my kart
	Then i should be able to reset the app state

Scenario Outline: Nav to Swaglabs about page
	Given i am logged in to the swaglabs page with the username "standard_user" and the password "secret_sauce"
	Then i should be able to navigate to the About page

