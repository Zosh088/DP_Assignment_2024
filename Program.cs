using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
=======
>>>>>>> d1a8c5b045b6d1009356a661b272a9b0cbaa8476
using System.Text;
using System.Threading.Tasks;

namespace DP_Assignment_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            // Create technicians
            var motorBikeTechnician = new Technician("MotorBikeTech", 100);
            var lightMotorTechnician = new Technician("LightMotorTech", 120);
            var heavyMotorTechnician = new Technician("HeavyMotorTech", 140);

            // Main loop
            while (true)
            {
                // Create vehicles
                Vehicle vehicle = null;

                GetMenu();

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        vehicle = new Vehicle("MotorBike");
                        vehicle.AttachObserver(motorBikeTechnician);
                        AssembleMotorbike(vehicle);
                        break;
                    case 2:
                        vehicle = new Vehicle("LightMotor");
                        vehicle.AttachObserver(lightMotorTechnician);
                        AssembleLightMotorVehicle(vehicle);
                        break;
                    case 3:
                        vehicle = new Vehicle("HeavyMotor");
                        vehicle.AttachObserver(heavyMotorTechnician);
                        AssembleHeavyMotorVehicle(vehicle);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        break;
                }
            }
        }
        static void GetMenu()
        {
            Console.WriteLine();
            Console.WriteLine("=====================================================");
            Console.WriteLine("║  Welcome to the Vehicle Assembling Application!   ║");
            Console.WriteLine("╠===================================================╣");
            Console.WriteLine("║  Choose the type of vehicle you want to assemble: ║");
            Console.WriteLine("╠===================================================╣");
            Console.WriteLine("║  1. Motorbike                                     ║");
            Console.WriteLine("║  2. Light Motor Vehicle                           ║");
            Console.WriteLine("║  3. Heavy Motor Vehicle                           ║");
            Console.WriteLine("║  4. Exit                                          ║");
            Console.WriteLine("╚===================================================╝");
        }
        static void AssembleMotorbike(Vehicle vehicle)
        {
            Console.WriteLine("Assembling Motorbike...");
            vehicle.SetCapability(new EngineCapability("Small"));
            vehicle.SetCapability(new CarrierCapability("Good and Driver"));

            SelectOptionalFeatures(vehicle);

            Console.WriteLine("Motorbike assembled!");
            Console.WriteLine("Vehicle Description: " + vehicle.Description);
            Console.WriteLine("Total Cost: " + (vehicle.CalculateTotalCost() + 0)); // Adding zero for formatting
            Console.WriteLine("===================================================");
        }

        static void AssembleLightMotorVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Assembling Light Motor Vehicle...");
            vehicle.SetCapability(new EngineCapability("Medium"));

            Console.WriteLine("Choose carrier capabilities:");
            Console.WriteLine("1. Good and Driver");
            Console.WriteLine("2. 2 people max, and bag");
            Console.WriteLine("3. 5 people max and few luggage");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            switch (choice)
            {
                case 1:
                    vehicle.SetCapability(new CarrierCapability("Good and Driver"));
                    break;
                case 2:
                    vehicle.SetCapability(new CarrierCapability("2 people max, and bag"));
                    break;
                case 3:
                    vehicle.SetCapability(new CarrierCapability("5 people max and few luggage"));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Using default carrier capabilities.");
                    vehicle.SetCapability(new CarrierCapability("Good and Driver"));
                    break;
            }

            SelectOptionalFeatures(vehicle);

            Console.WriteLine("Light Motor Vehicle assembled!");
            Console.WriteLine("Vehicle Description: " + vehicle.Description);
            Console.WriteLine("Total Cost: " + (vehicle.CalculateTotalCost() + 0)); // Adding zero for formatting
            Console.WriteLine("===================================================");
        }

        static void AssembleHeavyMotorVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Assembling Heavy Motor Vehicle...");
            vehicle.SetCapability(new EngineCapability("Large"));

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Choose towing capabilities:");
            Console.WriteLine("1. Can Tow");
            Console.WriteLine("2. Cannot Tow");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
        }

            switch (choice)
            {
                case 1:
                    vehicle.SetCapability(new TowingCapability("Can Tow"));
                    break;
                case 2:
                    vehicle.SetCapability(new TowingCapability("Cannot Tow"));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Using default towing capabilities.");
                    vehicle.SetCapability(new TowingCapability("Can Tow"));
                    break;
    }
            Console.WriteLine("---------------------------------------------------");
            SelectOptionalFeatures(vehicle);

            Console.WriteLine("Heavy Motor Vehicle assembled!");
            Console.WriteLine("Vehicle Description: " + vehicle.Description);
            Console.WriteLine("Total Cost: " + (vehicle.CalculateTotalCost() + 0)); // Adding zero for formatting
            Console.WriteLine("===================================================");
}

        static void SelectOptionalFeatures(Vehicle vehicle)
        {
            while (true)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Do you want to add optional features?");
                Console.WriteLine("1. Sound System");
                Console.WriteLine("2. WiFi");
                Console.WriteLine("3. Camera");
                Console.WriteLine("4. Done");

                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    return;
                }
                Console.WriteLine("---------------------------------------------------");
                switch (choice)
                {
                    case 1:
                        vehicle.AddOptionalFeature(new SoundSystem(vehicle));
                        break;
                    case 2:
                        vehicle.AddOptionalFeature(new WiFi(vehicle));
                        break;
                    case 3:
                        vehicle.AddOptionalFeature(new Camera(vehicle));
                        break;
                    case 4:
                        return; // Exit the function
                    default:
                        Console.WriteLine("Invalid choice. Not adding any optional feature.");
                        break;
                }
            }
        }
    }
}
