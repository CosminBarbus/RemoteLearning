<p align="center">
  
  <h1 align="center">Remote Learning</h1>
</p>

<br>

## Table of contents

- [The problem](#the-problem)


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
