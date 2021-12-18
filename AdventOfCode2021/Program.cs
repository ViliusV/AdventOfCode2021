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

			// Day 2: Dive
			var day2Dive = new Day2Dive();
			day2Dive.SetInputData();
			Console.WriteLine(day2Dive.MultiplyHorizontalPositionAndDepth());

			// Day 3: Binary Diagnostic
			var day3BinaryDiagnostic = new Day3BinaryDiagnostic();
			day3BinaryDiagnostic.SetInputData();
			Console.WriteLine(day3BinaryDiagnostic.CalculatePowerConsumption());
			
		}
	}
}
