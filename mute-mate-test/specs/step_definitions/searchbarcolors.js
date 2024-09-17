import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I am on the Practice Page colors', () => {
 cy.visit("/practice/colors");});

When('I click on the Searchbar', () => {
  cy.get(".search-input").should("be.visible").click();
});

When("I type in {string} in the Searchbar", (color) => {
  // Type the provided color into the search bar
  cy.get(".search-input")
    .clear() // Clear any pre-existing text in the search bar
    .type(color); // Type the color into the search bar
});

Then("I should se the {string} sign on the practice page", (color) => {
 
  cy.get(".practice-colors-image")
    .should("be.visible") // Kollar om elementet är visible
    
});

