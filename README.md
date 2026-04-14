# Warrior RPG System 🛡️
A simple console-based RPG character system built with C# to demonstrate the core principles of Object-Oriented Programming (OOP), specifically Inheritance, Encapsulation, and Method Overriding.
# 📝 Description
This project simulates a basic battle logic where different types of warriors have unique attributes and abilities. It showcases how a base class can be extended to create specialized units with distinct behaviors.
# 🚀 Features
Base Warrior Class: Handles core statistics like Health, Armor, and Damage.

Inheritance: Specialized classes (Knight and Barbarian) inherit from the base Warrior class.

Damage Logic: Includes a built-in mechanic to calculate health reduction based on armor points.

Unique Abilities:

Knight: Can use Pray() to increase defensive capabilities.

Barbarian: Features a calculated attack power based on attack speed and can use Shout() to trade armor for health.
# 🛠️ Technical Overview
## Class Hierarchy
1. Warrior (Base Class)
TakeDamage(int damage): Calculates damage using the formula:

                Health -= damage - Armor;
   
ShowHealthInfo(): Displays current health status.
2.Knight (Derived Class)
Inherits base stats.
Adds the Pray() method to buff Armor by +4.
3.Barbarian (Derived Class)
Constructor automatically calculates total damage based on attackSpeed.
Adds the Shout() method: Armor -2, Health +8.
# 💻 How to Run
1. Ensure you have the .NET SDK installed.
2. Clone this repository:
```bash
git clone https://github.com/Kernel-vlad/CSharp-BaseProject.git
```
3. Navigate to the project folder and run:
```bash
dotnet run
```
# 🧪 Example Output
```
Knight Health: -30
Barbarian Health: -40
```
(Note: Current logic allows health to go below zero for demonstration purposes.)
