# Lab01_UnitTesting

# CarFactoryLibrary Tests

This repository contains unit tests for the CarFactoryLibrary. The CarFactoryLibrary provides functionality for creating different types of cars and managing car stores.

## Table of Contents
1. [Introduction](#introduction)
2. [Project Structure](#project-structure)
3. [Test Descriptions](#test-descriptions)
4. [Setup Instructions](#setup-instructions)
5. [Contributing](#contributing)

## Introduction

The CarFactoryLibrary is a C# library that allows the creation of various car types, such as BMW, Toyota, Audi, etc. It also provides a CarStore class for managing collections of cars.

This repository contains unit tests written using xUnit to ensure the functionality of the CarFactoryLibrary is working as expected.

## Project Structure

The project is structured as follows:

- **CarFactoryLibrary_Tests**: Contains the unit tests for the CarFactoryLibrary.
  - **CarStoreTests.cs**: Tests for the CarStore class.
  - **CarFactoryTests.cs**: Tests for the CarFactory class.
  - **ToyotaTests.cs**: Tests for the Toyota class.

## Test Descriptions

### CarStoreTests
- **EmptyList_ListDoesNotContain**: Verifies that a newly created CarStore has an empty list of cars.
- **AddCars_AddBMW_TwoListContainsSameObjects**: Tests adding a BMW to two different CarStore instances and verifies that both stores contain the BMW.
- **AddCars_AddBMW_TwoListContainsDifferentObjects**: Tests adding a BMW and a Toyota to two different CarStore instances and verifies that they contain different sets of cars.
- **AddCar_AddBMW_ListContainsSingleObject**: Tests adding a single BMW to a CarStore and verifies that the store contains only one car.
- **AddCar_AddToyota_ListContainObject**: Tests adding a Toyota to a CarStore and verifies that the store contains the Toyota.
- **AddCars_AddListOfCars_CarsAddedToStore**: Tests adding a list of cars to a CarStore and verifies that all cars are added successfully.

### CarFactoryTests
- **AskForRefrence_same**: Tests creating two instances of Toyota and verifies that they are not the same reference.
- **NewCar_AskForAudi_null**: Tests requesting a new Audi car from the CarFactory and verifies that it returns null.
- **NewCar_AskForToyota_toyotaObject**: Tests requesting a new Toyota car from the CarFactory and verifies that it returns a Toyota object.
- **NewCar_TestForBMW_BMWObject**: Tests requesting a new BMW car from the CarFactory and verifies that it returns a BMW object.
- **NewCar_TestForToyota_ToyotaObject**: Tests requesting a new Toyota car from the CarFactory and verifies that it returns a Toyota object.
- **NewCar_AskForHonda_Exception**: Tests requesting a new Honda car from the CarFactory and verifies that it throws a NotImplementedException.

### ToyotaTests
- Tests various methods and properties of the Toyota class including boolean, numeric, and string assertions.

## Setup Instructions

To run these tests locally, follow these steps:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution to restore dependencies.
4. Run the tests using the test runner in your IDE.

## Contributing

Contributions are welcome! If you have any ideas, suggestions, or improvements, feel free to open an issue or create a pull request.
