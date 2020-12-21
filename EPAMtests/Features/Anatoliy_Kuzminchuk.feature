Feature: Epam web test

Scenario: 1Check graphic
Given I have open "https://www.epam.com/" 
When I click on "epam"
Then I see site refresh

Scenario: 2Check "Learn More" button 
Given I have open "https://www.epam.com/" 
When I click on "Learn MORE"
Then I see post about "EPAM work"

Scenario: 3Check letter picture 
Given I have open "https://www.epam.com/"
When I click on letter picture
Then I see form to contact with "EPAM"

Scenario: 5Check HowWeDoItLink 
Given I have open "https://www.epam.com/"
When I click on "How we do it"
Then I see howedoit information page

Scenario: 4Contact us check
Given I have open "https://www.epam.com/"
When I click on "contact us"
Then I see form to contact with "EPAM"

Scenario: 6Check "Careers"
Given I have open "https://www.epam.com/" 
When I click on "Careers"
Then I see form to find job offer in "Epam"

      