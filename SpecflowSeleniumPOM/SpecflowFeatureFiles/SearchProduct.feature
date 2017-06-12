Feature: SearchProduct

@mytag
Scenario: Search for a chelsea shirt
	Given I have gone to the Amazon homepage
	And I have search for a chelsea shirt
	When I select the item
	Then the link should show the correct item details
