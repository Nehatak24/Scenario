Feature: DifferentUsers
         As a User 
         Login with different users

@DifferentUsers
 Scenario : Check users
	Given I navigate to BMIPage	
	When I enter <username> and <password>
	Then I am able to login successfully
	Examples: 	
	|username|                         |password|
	|sheetal.samnani+1@bmigroup.com  | |password|
	|sheetal.samnani+777@bmigroup.com| |password|

	

	