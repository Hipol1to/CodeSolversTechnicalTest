Feature: Title validation


@Regression @PositiveScenarios
Scenario: Verify user can see the correct title when accessing the website
	Given user navigates to sauce demo web page
	Then the user should see the correct title

@Regression @PositiveScenarios
Scenario: Verify user is redirected to the inventory page after succesfully login
	Given user navigates to sauce demo web page
	When user logs in with valid credentials
	Then the user should be redirected to the inventory page

@Regression @NegativeScenarios
Scenario: Verify user can see an error after loging in with locked-out credentials
	Given user navigates to sauce demo web page
	When user logs in with locked-out credentials
	Then the page should show the locked-out error message