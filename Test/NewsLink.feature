Feature: NewsLink
	Checking news page

@News
Scenario: Check News page load successfully
	Given I Navigate to BBC
	And I Click on News
	Then I see news page load successfully
	And I Click on Sports
	Then I see sports page load successfully
