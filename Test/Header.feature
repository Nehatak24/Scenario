Feature: Header
	In order to view header pages
	As a user 
	I want to be able to click on Header links

@Header
Scenario Outline:Check header page loads
	Given I navigate to BBC
	When I click <headerlinks>
	Then I am able to see <headerlinks>
	Examples: 
	| headerlinks |
	| News        |
	| Weather     |