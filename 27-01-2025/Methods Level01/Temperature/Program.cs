using System;
class Temperature{
	static void Main(string[] args){
		//Input the Temperature from the user
    	Console.WriteLine("Enter temperature:");
    	double temp = Convert.ToDouble(Console.ReadLine());
		//Input the Wind Speed from the user
    	Console.WriteLine("Enter Wind Speed :");
    	double windSpeed = Convert.ToDouble(Console.ReadLine());
		//Display results
		Console.WriteLine($"Wind Chill is {CalculateWindChill(temp,windSpeed)}");
		
	}
	public static double CalculateWindChill(double temp, double windSpeed){
		double windChill = 35.74 + 0.6215 *temp + (0.4275*temp - 35.75) * Math.Pow(windSpeed,0.16 );
		return windChill;
	}
}