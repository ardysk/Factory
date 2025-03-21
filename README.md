# Factory Project

## Overview
This project is a solution to tasks from the second exercise in C#. In this exercise, we simulate a factory where both robots and humans work side by side.

## Description
In the factory, robots and people are employed. Robots are divided into computers and mechanical robots, while people are divided into physical workers and office workers. The tasks include:

- **Robot Annual Cost**:  
  Each robot provides an `AnnualCost()` method that returns the yearly cost of using the robot based on its type. The type is set in the constructor and differs between mechanical robots and computers.

- **Person Employment Cost**:  
  Each person provides a `Cost(int months)` method that returns the total cost of employing the worker over a specified number of months. The cost calculation is implemented differently for physical and office workers.

- **Internet Connection Interface**:  
  Both computers and office workers implement the `IInternetConnection` interface, which provides a getter for the `bool InternetConnection` property, indicating the current state of the internet connection.

- **Administration Lists**:  
  In the `Main` function, objects of each class are created and stored in three lists:
  - A list of all robots.
  - A list of all people.
  - A list of all positions (robots or people) that require an internet connection.
  
  The program then:
  - Sums the annual costs of all robots.
  - Sums the employment costs of all people for a given number of months.
  - Checks and displays the internet connection status for the positions that require it.

## Project Structure
- **Robot.cs**: Contains the abstract `Robot` class, which defines common properties and the abstract method `AnnualCost()`.
- **Computer.cs**: Implements the `Computer` class that derives from `Robot` and implements the `IInternetConnection` interface.
- **MechanicalRobot.cs**: Implements the `MechanicalRobot` class that derives from `Robot`.
- **Person.cs**: Contains the abstract `Person` class, which defines the abstract method `Cost(int months)`.
- **PhysicalWorker.cs**: Implements the `PhysicalWorker` class that derives from `Person`.
- **OfficeWorker.cs**: Implements the `OfficeWorker` class that derives from `Person` and implements the `IInternetConnection` interface.
- **IInternetConnection.cs**: Contains the definition for the `IInternetConnection` interface.
- **Program.cs**: Contains the `Main` method where objects are created, lists are managed, and costs are calculated.

## How to Run
1. **Prerequisites**: Ensure that you have the .NET SDK installed on your system.
2. **Setup**: Clone or download this repository.
3. **Build**: Open the solution in your preferred IDE (e.g., Visual Studio) and build the project.
4. **Execute**: Run the project. The console application will display:
   - The total annual cost for all robots.
   - The total employment cost for all people over a specified number of months.
   - The status of the internet connection for the applicable positions.

## Note
These tasks are part of the second exercise of C# lab.
