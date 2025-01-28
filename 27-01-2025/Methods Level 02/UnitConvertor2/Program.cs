using System;
class UnitConverter{
	//  Method to convert yards to feet and return the value
	public static double ConvertYardsToFeet(double yards) {
		double yardsToFeetFactor = 3;
		return yards * yardsToFeetFactor;
	}
	//Method to convert feet to yards and return the value
	public static double ConvertFeetToYards(double feet) {
		double feetToYardsFactor = 0.333333;
		return feetToYardsFactor * feet;
	}
	//Method to convert meters to inches and return the value
	public static double ConvertMetersToInches(double meters) {
		double metersToInchesFactor = 39.3701;
		return metersToInchesFactor * meters;
	}
	//Method to convert inches to meters and return the value
	public static double ConvertInchesToMeters(double inches) {
		double inchesToMetersFactor = 0.0254;
		return inches * inchesToMetersFactor;
	}
	//Method to convert inches to centimeters and return the value
	public static double ConvertInchesToCm(double inches){
		double inchesToCmFactor = 2.54;
		return inches * inchesToCmFactor;
	} 
	static void Main(string[] args){
		
        // Take input from the user
        Console.Write("Enter the distance in yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in feet: {ConvertYardsToFeet(yards):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in yards: {ConvertFeetToYards(feet):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in miles: {ConvertMetersToInches(meters):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in meters: {ConvertInchesToMeters(inches):F2}");
		
		// Take input from the user
        Console.Write("Enter the distance in inches: ");
        double inches2 = Convert.ToDouble(Console.ReadLine());

        // Call the ConvertKmToMiles method and display the result
		Console.WriteLine($"Distance in cms: {ConvertInchesToCm(inches2):F2}");
	}
}