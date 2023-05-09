Feature: Adding new Notebook

Background:
	Given I close Welcome modal window

Scenario: Add new Notebook
	Given I click on New Notebook button
	And I create notebook with name 'test name'
	Then new Notebook with 'test name' name is created in Notebooks area