# Welcome to the Drink_water wiki!
# Functional Requirements
#  Product Perspective 
## The application offers such features:
● Database of users and consumed water information.
● Calculate how much water the user should drink taking into account the age, gender, climate, activity during the day and height.
● Statistics of consumed water during one day, one week, one month, one year and also from a certain date. Users can track their progress using diagrams, reminds about the need to drink water 
## Product features 
● To use this application user must be registered. To register user have to enter a username, email and password(twice). Username and email must be unique, a password must contain at least 8 characters(1uppercase,1lowercase, 1digit, 1sign)
○ In case of entering a not unique username or email or too simple password user will be notified about it and will be asked to try to enter unique username/email or more complicated password.
○ In case of entering a not unique username or email, the user will be notified about it and will be asked to try to enter a unique username/email.
○ In the case of entering the correct data, the user is registered.
● Registered user can log in. To do this, the user has to enter a username and password.
 ○ In case of entering the wrong username or password, the user will be notified about it and will be asked to try to enter the correct username/password.
 ○ In case of entering the correct username and password, the user is logged in. 
 ○ In case of losing password user can restore it.
● Users can add consumed fluid during a day
○ water by default; 
○ to choose another fluid. 
● After at least one day of using user can view statistics and diagrams(by default statistics display 1 week of use, but user can change it). 
● User can edit his profile. 
● User can change password.
● Admin can log in,  use an application like any other registered user. 
● Admin can watch users statistics and time when users were registered.

# Nonfunctional Requirements 
## Performance Requirements 
This application aims to help people in water balance control by sending notifications. It is very important to provide notification sending on time (especially when there are a lot of users use application). 
Safety Requirement 
This application can be used in one scenario: for personal use.  Many users can use the same passwords for different accounts, including bank ones, therefore it is important to provide protection against brute-forth and other attacks. 
Security Requirement  
As this application is for the personal use it is enough to exclude the possibility to access the database.
Software Quality Attributes
 ● Availability: The application functionality should be available at any time in full.
 ● Correctness:  The application should contain only valid formulas for calculations. 
 ● Maintainability: The administrators should maintain user information database. But no one could be able to edit other users’ information.
 ● Usability: The application should satisfy the maximum number of customers’ needs. 
## Acceptance criteria 
Scenario 1: Sign up with new login and correct password 
Given: The login has not been taken and password correct 
When: User is not signed in 
Then: The new user was created 

Scenario2: Sign up with new login and invalid password 
Given: The login has not been taken and password invalid 
When: User is not signed in 
Then: The new user is not created, the error displayed 

Scenario3: Sign up with taken login 
Given: The login has not been taken 
When: User is not signed in 
Then: The new user is not created, the error displayed

Scenario4: Sign out 
Given: Sign out button pressed 
When: User is signed in 
Then: The session for the current user is closed 

Scenario5: Add consumed water
Given: The user is  signed in 
When: Add water page is displayed 
Then: The amount of consumed water increased by a specified number.

Scenario6: Change information
Given: The user is  signed in 
When: Settings page is selected
Then: User changes information and confirms it.

Scenario7: View statistics
Given: The user is signed in and use the application at least one day
When: User selects the “Statistics” button
Then: Diagrams and statistics information is displayed

Scenario8: Close statistics
Given: The user is signed in 
When:  Statistics page is open
Then: Close statistics and redirect to the main page

Scenario9: Change notification schedule
Given: The user is signed in
When: User want to change the notification frequency
Then: Notifications are sending with a given frequency

Scenario10: Change the fluid
**Given**: The user is signed in, main pave with drunk water are loaded
**When**: The user presses the fluid icon
**Then**: The fluid icon is changed and the user can add this fluid to “consumed per day”

