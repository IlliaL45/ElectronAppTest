Feature: Adding new Notebook

Scenario: Add new Notebook
	Given I click on New Notebook button
	When I create notebook with name 'test name' 
	Then new Notebook with 'test name' name is created
	And I delete 'test name' notebook