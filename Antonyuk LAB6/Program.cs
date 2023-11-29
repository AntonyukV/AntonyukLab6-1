using System;
using System.Collections.Generic;

// Абстрактний клас Vehicle
public abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас Human
public class Human
{
    public int Speed { get; set; }

    public void Move()
    {
        Console.WriteLine("Human is moving.");
    }
}

// Спадкоємці класу Vehicle
public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

public class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bus is moving.");
    }
}

public class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Train is moving.");
    }
}

// Клас Route
public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
}

// Клас TransportNetwork
public class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void ControlMovement()
    {
        foreach (var vehicle in vehicles)
        {
            vehicle.Move();
        }
    }

    public string CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        // Логіка розрахунку оптимального маршруту
        return $"Optimal route from {route.StartPoint} to {route.EndPoint} for {vehicle.GetType().Name} is calculated.";
    }

    public void PassengerHandling(Vehicle vehicle)
    {
        // Логіка посадки та висадки пасажирів
        Console.WriteLine($"Passengers are boarding and alighting from {vehicle.GetType().Name}.");
    }
}

class Program
{
    static void Main()
    {
        // Приклад використання класів
        Car car = new Car { Speed = 60, Capacity = 5 };
        Bus bus = new Bus { Speed = 40, Capacity = 30 };
        Train train = new Train { Speed = 100, Capacity = 200 };

        TransportNetwork transportNetwork = new TransportNetwork();
        transportNetwork.AddVehicle(car);
        transportNetwork.AddVehicle(bus);
        transportNetwork.AddVehicle(train);

        transportNetwork.ControlMovement();

        Route route = new Route { StartPoint = "A", EndPoint = "B" };
        Console.WriteLine(transportNetwork.CalculateOptimalRoute(route, car));

        transportNetwork.PassengerHandling(bus);
    }
}
