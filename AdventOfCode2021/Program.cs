using AdventOfCode2021.Challenges;
using System;

namespace AdventOfCode2021
{
	class Program
	{
		static void Main()
		{
			// Day 1: Sonar Sweep
			var day1SonarSweep = new Day1SonarSweep();
			day1SonarSweep.SetInputData();
			Console.WriteLine(day1SonarSweep.CalculateIncreasedMeasurements());
			Console.WriteLine(day1SonarSweep.CalculateIncreasedGroupMeasurements());
			
		}
	}
}
