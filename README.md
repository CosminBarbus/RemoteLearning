<p align="center">
  
  <h1 align="center">Remote Learning</h1>
</p>

<br>

## Table of contents

- [The problem](#the-problem)
- [Session 1](#session-1)
- [Session 2](#session-2)
- [Session 3](#session-3)
- [Session 4](#session-4)
- [Session 5](#session-5)
- [Session 6](#session-6)
- [Session 7](#session-7)
- [Session 8](#session-8)

## The problem

Development of a vending machine: "A vending machine is an automated machine that provides items such as snacks, beverages, alcohol, cigarettes and lottery tickets to consumers after money or a credit card is inserted into the machine.
[Vending Manchine](https://en.wikipedia.org/wiki/Vending_machine)

Concepts:
- The vending machine will offer Products. The products will have the following attributes:
   - Type of products
   - Name
   - Price
   - Quantity
   - Size (how many columns are used by the products)
- The vending machine has a Dispenser that contains all the products. The dispenser will dispense one product as a result of a payment:
   - Construction: cells
- In order to obtain a product from the machine, a Payment has to be made. The vending machine should support the following payment methods:
   - With coins
   - With banknote
   - With credit card - for credit card no pin is required (Contact Less)
- Payment flow:
   - The client specifies the selected product by providing the productId
   - The client select the payment method: Coins, Banknotes or CreditCard
   - The client pays the necessary amount
   - The machine gives back change if needed
   - The product is dispensed
- In order to analyse the profitability of the vending machine, following data is collected and stored. Later, the statistics will be presented using CSV reports:
   - Sales (product, quantity, price, value, date)
   - Volume (product, total quantity)
   - Actual stock (product, current stock)
 

## Session 1

Animal Instinct project :)

## Session 2

To Do:
- Draw the conceptual model of the [The problem](#the-problem):
  - [to read](http://www.cs.toronto.edu/~jm/340S/PDF2/CM2.pdf)
  - Identify all the concepts
  - Identify the interaction between them
  - Draw a simple diagram (line and boxes) that covers all the identified concepts
 
## Session 3

Phase 1: discuss about conceptual models

Phase 2: Select the Product concept and discuss the requirements for it:

 - The vending machine should contain a wide categories of products
 - The vending machine has a collection of products
 - All products have the same attributes: price, category
 - The vending machine can have more products of the same type
 - Introduce UML (Class and Relations) - https://www.tutorialspoint.com/object_oriented_analysis_design/ooad_uml_basic_notation.htm

Home work:
 - Draw the Product and the ProductCollection classes using UML. The diagram should depict the relation between the classes
 - Implement the Product and the ProductCollection:
    - Take into account the collection behavior:
      - Add, Remove, Count, GetItem
    - Bonus:
     - Draw one sequence diagrams that indicates the ProductCollection behavior's

## Session 4

Phase 1: discuss about implementations

Phase 2: The product can be located inside the vending machine by row, column and size

 - the produc can be removed
 - discuss about inherintance
 
 Home work:
 
  - To read:
    - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance
    - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
  - Update the conceptual model and the class diagram
  - implement the ContainableItem and update the ProductCollection (also change its name)
## Session 5

Phase 1: discuss about Inheritance vs Composition and another perspective of the ContainableItem
a ContainableItem can have a Product or a Product is a ContainableItem

Phase 2:
Introduce a new requirement. An item can be disposed.

Home work:
 - To read:  https://web.archive.org/web/20170721042926/https://www.microsoft.com/net/tutorials/csharp/getting-started/encapsulation-oop
 - Update the conceptual model and the class diagram
 - Implement the Dispenser
## Session 6

Phase 1: discuss about the home work

Phase 2:

Introduce a new requirement. You have to pay for the selected item.

 - Introduce the concept of PaymentTerminal:
   - Collect the money
      - Coins
      - Banknote
      - CreditCard - details will be added in Session 07
   - Give change (only coins)
   
 Home work
 
  - To read: http://www.oodesign.com/observer-pattern.html or http://www.dofactory.com/net/observer-design-pattern
  - Update the conceptual model and the class diagram
  - Implement the Payment

## Session 7
There is an issue with the OnPayment event. Everybody can trigger the payment because Notify is public.

New requirement: You have to pay for the selected item.
 - Update the concept of Payment in order to support credit cards
   - credit card should be validated
   - the payment should be handled by a thrid component (mocked)

Home work
  - Redesign the PaymentEvent so Notify is accessible only by PaymentTerminal
  - Update the conceptual model and the class diagram
  - Implement the CreditCard Payment
## Session 8 Collect Data
Introduce a new requirement. We need some statistical reports to understand if our business is profitable or not. In order to produce the reports, data has to be collected.

Sigleton or Repository Pattern.

Home work
 - Update the conceptual model and the class diagram
 - Implement the Database component - in memory storage

## Session 9
## Session 10
