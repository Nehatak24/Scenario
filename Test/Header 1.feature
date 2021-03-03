Feature: Header
	In order to view Header pages
	As a user 
	I want to be able to click on Header links

@Header
Scenario Outline:Check headerpage Loads
	Given I navigate to BBC
	When I click on <headerlinks>
	Then I see <headerlinks>
	Examples: 
	| headerlinks|
	|    News     |
	|    Weather  |