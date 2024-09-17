Feature: Searchbar Animals

Scenario: Search for a animal sign
Given that I am on the Practice Page animals
When I click on the Searchbar on the practice animals page
And I type in "bear" in the Searchbar on the practice animals page
Then I should see the "bear" sign on the animals practice page
