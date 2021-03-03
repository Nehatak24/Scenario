Feature: LoginMulti
	As a user I wants to login with different users

@LoginMulti
Scenario Outline :Login with multi users successfully
	Given I navigate to BMIPage
	When I enter <username> and <password>
	Then I am logged in with different users successfully