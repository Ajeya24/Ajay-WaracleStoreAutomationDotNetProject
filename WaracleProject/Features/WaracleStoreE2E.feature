Feature: E2E test for Waracle Store

Scenario Outline: AC-1
Given User launches the Waracle store
When User logs using valid "<UserName>" and "<Password>" credentials
Then User should land successfully on the home page of the Waracle store
Then User clicks on Shop Now button 
Then User adds an item to the cart
And User enters the "<CouponCode>"
And User applies the coupon code
Then validate whether the appropriate message is displayed for the applied coupon code

Examples:
| UserName             | Password    | CouponCode |
| john.doe@example.com | Password123 | WARACLE25  |

Scenario Outline: AC-2
 Given User launches the Waracle store
 When User logs using valid "<UserName>" and "<Password>" credentials
 Then User should land successfully on the home page of the Waracle store
 Then User clicks on Shop Now button 
 Then User adds an item to the cart
 And User enters the "<CouponCode>"
 And User applies the coupon code
 Then validate that coupon applied is displayed in the cart summary
    
Examples:
| UserName             | Password    | CouponCode |
| john.doe@example.com | Password123 | WARACLE25  |

Scenario Outline: AC-3
 Given User launches the Waracle store
 When User logs using valid "<UserName>" and "<Password>" credentials
 Then User should land successfully on the home page of the Waracle store
 Then User clicks on Shop Now button 
 Then User adds an item to the cart
 And User enters the "<CouponCode>"
 And User applies the coupon code
 Then validate that shipping charges are displayed to non empty basket
 
Examples:
 | UserName             | Password    | CouponCode |
 | john.doe@example.com | Password123 | WARACLE25  |
 
Scenario Outline: AC-4
 Given User launches the Waracle store
 When User logs using valid "<UserName>" and "<Password>" credentials
 Then User should land successfully on the home page of the Waracle store
 Then User clicks on Shop Now button 
 Then User adds an item to the cart
 And User enters the "<CouponCode>"
 And User applies the coupon code
 
Examples:
 | UserName             | Password    | CouponCode |
 | john.doe@example.com | Password123 | WARACLE25  |
 
Scenario Outline: AC-5
 Given User launches the Waracle store
 When User logs using valid "<UserName>" and "<Password>" credentials
 Then User should land successfully on the home page of the Waracle store
 Then User clicks on Shop Now button 
 Then User adds an item to the cart
 And User enters the "<CouponCode>"
 And User applies the coupon code
 
Examples:
 | UserName             | Password    | CouponCode |
 | john.doe@example.com | Password123 | WARACLE45  |
 

Scenario Outline: AC-6
 Given User launches the Waracle store
 When User logs using valid "<UserName>" and "<Password>" credentials
 Then User should land successfully on the home page of the Waracle store
 Then User clicks on Shop Now button 
 Then User adds an item to the cart
 And User enters the "<CouponCode>"
 And User applies the coupon code
 And User user proceeds to checkout
 And User enters Shipping Address "<Address>""<City>""<PostCode>"
 And User enters Payment Details "<CardNumber>""<ExpiryDate>""<CVC>"
 And User clicks on pay button on Order Summary page
 And validate that total and coupon applied is displayed on Order Confirmation page


 
Examples:
 | UserName             | Password    | CouponCode | Address       | City `    | PostCode  | CardNumber       | ExpiryDate | CVC |
 | john.doe@example.com | Password123 | WARACLE25  | 10 Joel Street| EdinBurgh | `EH11A   | 4242424242424242|  12/26     | 123 |