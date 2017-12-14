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
