# _Pierre's Bakery_

#### _C# Independent Project for Epicodus_, _Feb. 28, 2020_

#### By _**Michelle Morin**_

## Description

_This project is a console application for a bakery. When a user runs the application, they receive a prompt with a welcome message along with bread and pastry costs. A user may specify how many loaves of bread and/or how many pastries they'd like, and the application will return the total cost of the order. The total cost determination takes into account the following price structure:_ 
* _a loaf of bread is $5_
* _bread is 3 loaves for $10 (i.e., buy 2, get 1 free))_
* _bread is 10 loaves for $30_
* _pastries are $2/each_
* _pastries are 3 for $5_
* _pastries are 20 for $30_
_Multiple "deals" may be applied to an order. For example, an order of 24 pastries receives a $30 for 20 pastries deal and a $5 for 3 pastries deal, while the 24th pastry is full price ($2) for an order total of $37. If a user selects to add additional pastries and/or bread to their order, the application will calculate the order total (and available discounts) based on the total number of pastries and/or bread added during the session (e.g., until the user selets to quit the application). If the user of the aforementioned example chooses to add 2 more pastries to their order (26 total pastries), the order total will reflect a $30 for 20 pastries deal and two $5 for 3 pastries deals for an order total of $40._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application greets user with welcome message when user starts application | User enters "dotnet run" in Terminal | "Welcome to Pierre's Bakery! Bread is $5/loaf or $10/three loaves; pastries are $2/each or $5/three pastries." |
| Application asks user if they would like to purchase bread, pastry, or both | (N/A, this will occur after aforementioned welcome message) | "Would you like to purchase bread, pastry, or both?" |
| When user enters "bread", the application prompts the user to enter a bread loaf quantity. | "bread" | "Please enter a quantity of bread loaves you would like to purchase:" |
| When user enters "pastry", the application prompts the user to enter a pastry quantity. | "pastry" | "Please enter a quantity of pastries you would like to purchase:" |
| When user enters "both", the application prompts the user to enter a bread loaf quantity, then prompts the user to enter a pastry quantity after user inputs loaf quantity. | "both" | "Please enter a quantity of bread loaves you would like to purchase:", (after user enters response to first question:) "Please enter a quantity of pastries you would like to purchase:" |
| Application returns total price of bread order based on user input quantity | 3 | $10 |
| Application returns total price of pastry order based on user input quantity | 3 | $5 |
| Application returns total price of bakery order based on user input quantities for bread and pastries | 1, 2 | $9 |
| Application prompts user to add pastry, bread, or both to order, and quits application when user responds with "quit" or "no" | "no" | "Come again soon!" |
| Application allows a user to continue adding bread and/or pastry to their order, and updates the total price based on all previously specified quantities of bread and pastry | "bread", 1 | application displays updated total price of all items added to order |
| Application allows a user to continue adding bread and/or pastry to their order, and keeps track of the total quantity of bread and pastry in user's order history | "both", 1, 2 | application displays updated total quantities of bread and pastries in user's order |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone https://github.com/michelle-morin/Bakery``
* ``cd Bakery``

_Confirm that you have navigated to the Bakery directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of the Bakery directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin_**