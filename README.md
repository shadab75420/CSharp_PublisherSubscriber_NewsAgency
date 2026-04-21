# C# Publisher-Subscriber Model (News Agency)

## Problem Statement

This project demonstrates the Publisher-Subscriber (Observer) design pattern using C#.
A News Agency publishes news on different topics, and readers subscribe to receive updates based on their interests.

The system ensures loose coupling between the publisher and subscribers using delegates and events.

---

## Features

* Implements Publisher-Subscriber (Observer) pattern
* Supports multiple subscribers
* Subscribers receive only relevant topic-based updates
* Uses delegates and events for communication
* Simple console-based implementation

---

## Technologies Used

* C#
* .NET
* Delegates and Events

---

## Functionality Overview

### Publisher (NewsAgency)

* Publishes news articles
* Raises an event when news is published

### Subscriber (Reader)

* Subscribes to the publisher
* Receives notifications based on interested topic

### Event Mechanism

* `OnNewsPublished` event connects publisher and subscribers
* Automatically notifies all subscribed users

---

## Code Structure

* `Program.cs` → Main execution
* `NewsAgency.cs` → Publisher logic
* `Reader.cs` → Subscriber logic

---

## Sample Output

[NewsAgency] Publishing Sports news: India won the match!
Aman received Sports news: India won the match!

[NewsAgency] Publishing Politics news: New policy announced.
Sai received Politics news: New policy announced.

[NewsAgency] Publishing Entertainment news: New movie released!
Raj received Entertainment news: New movie released!

---

## How to Run the Code

1. Open the project in Visual Studio
2. Build the solution
3. Run the program (Ctrl + F5 or F5)
4. Observe how subscribers receive updates

---

## Key Concepts

* Observer Design Pattern
* Loose Coupling
* Delegates
* Events

---

