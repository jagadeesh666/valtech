Feature: Valtech

@valtech
Scenario: Jobs page
	Given I am on Home Page and has 'latest News' displayed.
	When I click on Careers tab.
	Then the page heading has 'careers' displayed.

Scenario: Services page
	Given I am on Home Page and has 'latest News' displayed.
	When I click on Services tab.
	Then the page heading has 'services' displayed.
	
Scenario: Cases page
	Given I am on Home Page and has 'latest News' displayed.
	When I click on Works tab.
	Then the page heading has 'Works' displayed.

Scenario: Contacts page
	Given I am on Home Page and has 'latest News' displayed.
	When I click on Contacts icon.
	Then the page should display 13 countries