import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I am on the Practice Page animals', () => {
 cy.visit("/practice/animals");});

When('I click on the Searchbar on the practice animals page', () => {
  cy.get(".search-input").should("be.visible").click();
});

When('I type in {string} in the Searchbar on the practice animals page', (a) => {
  cy.get(".search-input").clear().type(a);

});

Then('I should see the {string} sign on the animals practice page', (a) => {
  cy.get(".practice-animals-tecken-image").should("be.visible"); // Kollar om elementet är visible
});