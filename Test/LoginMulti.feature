Feature: LoginMulti
	As a user 
	I want to login with different users

@LoginMulti 
Scenario Outline:Login with different Users
Given I navigate to BMIPage
When I enter <username> and <password>
Then I am logged in with that users successfully
Examples:
    |username || password |
    |sheetal.samnani+1@bmigroup.com  ||password|
    |sheetal.samnani+777@bmigroup.com||password|