# _Pierre's Bakery_

#### _C# Independent Project for Epicodus_, _Feb. 28, 2020_

#### By _**Michelle Morin**_

## Description

_This project is a C# console application for a bakery. When a user runs the application, they receive a prompt with a welcome message along with the cost for both bread and pastry. A user may specify how many loaves of bread and how many pastries they'd like, and the application will return the total cost of the order. The total cost determination takes into account the following price structure: bread is buy 2, get 1 free; a single loaf of bread is $5; a pastry is $2 or 3 pastries for $5._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application greets user with welcome message when user starts application | User enters "dotnet run" in Terminal | "Welcome to Pierre's Bakery! We sell bread for $5/loaf or $10/three loaves, and also sell pastries for $2/each or $5/three pastries. |
| Application asks user if they would like to purchase bread, pastry, or both | (N/A, this will occur upon welcome message) | "Would you like to purchase bread, pastry, or both?" |
| When user enters "bread", the application prompts the user to enter how many loaves of bread they would like to purchase. | "bread" | "Please enter a quantity of bread loaves you would like to purchase:" |
| Application returns total price of bread order based on user input quantity | 3 | $10 |
| When user enters "pastry", the application prompts the user to enter how many pastries they would like to purchase. | "pastry" | "Please enter a quantity of pastries you would like to purchase:" |
| Application returns total price of pastry order based on user input quantity | 3 | $5 |
| When user enters "both", the application prompts the user to enter how many bread loaves they would like to purchase, then prompts the user to enter how many pastries they would like to purchase. | "both" | "Please enter a quantity of bread loaves you would like to purchase:", (after user enters response to first question:) "Please enter a quantity of pastries you would like to purchase:" |
| Application returns total price of bakery order based on user input quantities for bread and pastries | 1, 2 | $9 |

## Setup/Installation Requirements

_Clone this repository via Terminal using the following commands:_
* ``$ cd desktop``
* ``$ git clone https://github.com/michelle-morin/camping``
* ``$ cd Bakery``

_Confirm that you have navigated to the Bakery directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Open this console application using the following command:_
* ``$ dotnet run``

_To view/edit the source code of this application, open the contents of the Bakery directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**