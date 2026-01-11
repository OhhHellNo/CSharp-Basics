using System;

class Program
{
    public static void Main(string[] args)
    {
        // Getters and setters = add security to the fields by encapsulation.
        // They are the accessors found within the properties.
        // Get accessor is used to return the property values.
        // Set accessor is used to assign a new value.

        Car car = new Car(100);

        Console.WriteLine("Initial speed: " + car.Speed);

        car.Speed = 300;
        Console.WriteLine("After setting 300: " + car.Speed);

        car.Speed = 600; // Will be limited to 500
        Console.WriteLine("After setting 600: " + car.Speed);
    }
}

class Car
{
    private int speed;

    // Constructor
    public Car(int speed)
    {
        Speed = speed; 
    }


    public int Speed
    {
        get { return speed; }

        set
        {
            if (value > 500)
            {
                speed = 500;
            }
            else
            {
                speed = value;
            }
        }
    }
}