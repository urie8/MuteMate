Feature: Searchbar Letters

Scenario: Search for a letter sign
Given that I am on the Practice Page letters
When I click on the Searchbar on the practice letters page
And I type in "a" in the Searchbar on the practice letters page
Then I should see the "a" sign on the letters practice page
