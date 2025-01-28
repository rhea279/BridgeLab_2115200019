using System;

class UnitConverter
{
    // Method to convert kilometers to miles
    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    // Method to convert miles to kilometers
    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    // Method to convert meters to feet
    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    // Method to convert feet to meters
    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }
	
	static void Main(string[] args){
		
		// Take input from the user
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in miles: {ConvertKmToMiles(km):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in kilometers: {ConvertMilesToKm(miles):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in feet: {ConvertMetersToFeet(meters):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in meters: {ConvertFeetToMeters(feet):F2}");
		
	}
}