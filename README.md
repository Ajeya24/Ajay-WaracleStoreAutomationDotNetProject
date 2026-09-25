# Ajay-WaracleStoreAutomationDotNetProject
A repository for automating Waracle store test scenarios

Warble Store Automation
----------------------------------------------------------------------------------------
Automated test scenarios for Waracle store using below dependencies
.NET 8
Microsoft Playwright
Reqnroll
Unit

Project Setup and Execution
-----------------------------------------------------------------------------------------
The Application URL is: 
{
    "baseUrl": "http://localhost:5173/"
   
}

To Execute the tests build the project and run the tests using the Test Explorer


Framework Approach
------------------------------------------------------------------------------------------
A behavioural data driven approach using Feature files and Step Definitions to build the Tests combined with POM Design pattern with Playwright test logic implemented across Pages and called
In step definition files.

Issues Observed
------------------------------------------------------------------------------------------
After implementing the WARACLE25 coupon code the sum total calculation of the Shopping Bag
Isn't correct and on applying a wrong coupon code no suitable error message displayed

