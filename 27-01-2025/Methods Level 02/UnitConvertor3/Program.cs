using System;
class UnitConverter{
	//Method to convert Fahrenheit to Celsius and return the value
	public static double ConvertFarhenheitToCelsius(double farhenheit) {
		double farhenheitToCelsius= (farhenheit - 32) * 5 / 9;
		return farhenheitToCelsius;
	}
	//Method to convert Celsius to Fahrenheit and return the value
	public static double ConvertCelsiusToFarhenheit(double celsius) {
		double celsiusToFarhenheit =  (celsius * 9 / 5) + 32;
		return celsiusToFarhenheit;
	}
	//Method to convert pounds to kilograms and return the value
	public static double ConvertPoundsToKilogram(double pounds) {
		double poundsToKilogram = 0.453592;
		return pounds*poundsToKilogram;
	}
	//Method to convert kilograms to pounds and return the value
	public static double ConvertKilogramsToPounds (double kilograms) {
		double kilogramsToPounds  =  2.20462;
		return kilograms * kilogramsToPounds;
	}
	//Method to convert gallons to liters and return the value
	public static double ConvertGallonsToLiters(double gallons){
		double gallonsToLiters = 3.78541;
		return gallons*gallonsToLiters;
	} 
	//Method to convert liters to gallons and return the value
	public static double ConvertLitersToGallons(double liters){
		double litersToGallons = 0.264172;
		return liters * litersToGallons;
	}
	static void Main(string[] args){
		
        // Take input from the user
        Console.Write("Enter temperature in fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Temperature in Celsius: {ConvertFarhenheitToCelsius(fahrenheit):F2}");
		
		// Take input from the user
        Console.Write("Enter temperature in celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Temperature in Fahrenheit: {ConvertCelsiusToFarhenheit(celsius):F2}");
		
		// Take input from the user
        Console.Write("Enter the weight in pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Weight in kilograms: {ConvertPoundsToKilogram(pounds):F2}");
		
		// Take input from the user
        Console.Write("Enter the weight in kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Weight in Pounds: {ConvertKilogramsToPounds(kilograms):F2}");
		
		// Take input from the user
        Console.Write("Enter the weight in gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Weight in Liters: {ConvertGallonsToLiters(gallons):F2}");
		
		// Take input from the user
        Console.Write("Enter the weight in liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"Weight in Gallons: {ConvertLitersToGallons(liters):F2}");
	}
}