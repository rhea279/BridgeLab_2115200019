using System;
class Friends{
	static void Main(string[] args){
		//Input age and height for the 3 friends
		int[] ht = new int[3];
		int[] age = new int[3];
		
		for(int i = 0 ; i < 3; i++){
			Console.Write($"Enter Friend {i+1} Age:");
			age[i] = Convert.ToInt32(Console.ReadLine());
			Console.Write($"Enter Friend {i+1} Height:");
			ht[i] = Convert.ToInt32(Console.ReadLine());
		}
		Youngest(age);
		Tallest(ht);
	}
	static void Youngest(int[] age){
		int youngestAge = age[0];
		int youngestFrnd = 0;
		for(int i = 0 ; i< 3; i++){
			if(age[i]<youngestAge){
				youngestAge = age[i];
				youngestFrnd = i;
			}
		}
		Console.Write($"Friend {youngestAge} is the Youngest\n");
	}
	static void Tallest(int[] ht){
		int tallest = ht[0];
		int tallestFrnd = 0;
		for(int i = 0 ; i< 3; i++){
			if(ht[i]>tallest){
				tallest = ht[i];
				tallestFrnd = i;
			}
		}
		Console.Write($"Friend {tallestFrnd} is the Tallest");
	}
}