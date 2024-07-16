# Vehicle Assembly Console Application
## Overview
This project is a console application designed to simulate a vehicle assembly line for ABC Systems. The application allows users to assemble different types of vehicles (Motor Bikes, Light Vehicles, Heavy Vehicles) with customizable capabilities and optional features. The project leverages three key design patterns: Strategy, Observer, and Decorator, to provide a flexible, maintainable, and extensible solution.

### Features
Vehicle Types: Motor Bikes, Light Vehicles, Heavy Vehicles
### Capabilities:
Carrier Capacity, Engine Size, Towing Capability, Optional Features: Sound System, WiFi, Camera

Technician Management: Technicians for different vehicle types, with specific hourly rates for adding features
# Design Patterns Used
## Strategy Pattern

Encapsulates vehicle capabilities (carrier, engine, towing) as separate strategies. Allows dynamic setting of capabilities without modifying the vehicle class.
## Observer Pattern

Enables real-time updates to technicians about vehicle state changes. Maintains loose coupling between the vehicle and technician classes.
## Decorator Pattern

Facilitates dynamic addition of optional features (sound system, WiFi, camera) to vehicles. Adheres to the Single Responsibility Principle by keeping each feature in its own class.
# Class Diagram

## Classes:
### Vehicle

Manages capabilities, optional features, and technicians. Notifies technicians of state changes.
### Technician

Observes vehicle state changes. Calculates cost for adding features based on hourly rates.
### Capabilities

CarrierCapability, EngineCapability, TowingCapability
### Optional Features

SoundSystem, WiFi, Camera
# Contact
For any questions or suggestions, please feel free to contact:

Name: Zenande Mjali

Email: mjalizenande06@gmail.com
