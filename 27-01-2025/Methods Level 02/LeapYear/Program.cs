using System;
class LeapYear{
	static void Main(string[] args){
		//Input a year from user
		Console.Write("Enter a Year :");
		int year = Convert.ToInt32(Console.ReadLine());
		
		// Check if the entered year is a leap year and display the result
		if(CheckYear(year)){
			Console.WriteLine($"{year} is a Leap Year.");
		}else{
			Console.WriteLine($"{year} is not a Leap Year.");
		}
	}
	// Method to determine if a year is a leap year
	static bool CheckYear(int year){
		if(year >= 1582){
			if(year % 4 == 0){
				if(year % 100 != 0 || year % 400 == 0){
					return true;
				}
			}
		}
		return false;
		
	}
	
}