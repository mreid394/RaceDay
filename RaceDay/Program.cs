using System;

class Program
{
	static void Main()
	{
		// Generate a random race number between 0 and 999
		Random random = new Random();
		int raceNumber = random.Next(0, 1000);

		// Variables to indicate if the runner registered early and their age
		bool earlyRunner = false;
		int runnerAge = 18;

		// If the runner is an adult and registered early, add 1000 to their race number
		if (runnerAge > 18 && earlyRunner)
		{
			raceNumber += 1000;
		}

		// Determine race time based on age and registration status
		if (runnerAge > 18 && earlyRunner)
		{
			Console.WriteLine($"Your race number is {raceNumber} and the race starts at 9:30am.");
		}
		else if (runnerAge > 18 && !earlyRunner)
		{
			Console.WriteLine($"Your race number is {raceNumber} and the race starts at 11am.");
		}
		else if (runnerAge < 18)
		{
			Console.WriteLine($"Your race number is {raceNumber} and the race starts at 12:30pm.");
		}
		else
		{
			// For runners aged exactly 18, direct them to the registration desk
			Console.WriteLine("Go to the registration desk.");
		}
	}
}