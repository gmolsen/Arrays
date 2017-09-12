using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace TestArrayLibrary {
	class Program {

		void Run() {
			Bowling();
			var aStudent = LearningArrays.Students[0];
			var score = LearningArrays.TestScores[0];
			Console.WriteLine($"The fourth student in the array is {aStudent}, and their test score is {score}");
			// iterating through all the items in the array
			var Total = 0;
			// always use .Count() method for indexing arrays
			for (var idx = 0; idx < LearningArrays.TestScores.Count(); idx++) {
				Total += LearningArrays.TestScores[idx];
			}
			// Total is casted as a double to display the true average
			var Average = ((double)Total) / LearningArrays.TestScores.Count();
			Console.WriteLine($"The sum of the scores is {Total} and the average is {Average}");
		}

		void Bowling() {
			//var Total = 0;
			//	for (var idx = 0; idx < LearningArrays.BowlingGame.Count(); idx++) {
			//		Total += LearningArrays.BowlingGame[idx];
			// shorthand version of this iteration below	}
			//foreach (var score in LearningArrays.BowlingGame) {
			//	Total += score;
			//}
			//var average = ((double)Total) / LearningArrays.BowlingGame.Count();
			//Console.WriteLine($"The total bowling score is {Total}");
			//Console.WriteLine($"The average bowling score is {Total / LearningArrays.BowlingGame.Count()}");
			var Total = 0;
			// shorthand version of iteration performed above by for loop
			for (var idx = 0; idx < LearningArrays.Frames.Count(); idx++) {
				Total += LearningArrays.Frames[idx];
			}
			Console.WriteLine($"The total bowling score is {Total}");
			Console.WriteLine($"The average bowling score is {Total / LearningArrays.Frames.Count()}");
			// multi-dimensional arrays
			Console.WriteLine($"Bowling score 1, 6 is {LearningArrays.BowlingScores[1, 6]}");

			LearningArrays.GradingScores.Add(94);
			LearningArrays.GradingScores.Add(97);
			LearningArrays.GradingScores.Add(89);
			LearningArrays.GradingScores.Add(93);
			LearningArrays.GradingScores.Add(92);
			LearningArrays.GradingScores.Remove(97);
			var idxGrades = LearningArrays.GradingScores.IndexOf(92);
			LearningArrays.GradingScores[idxGrades] = 65;
			Console.WriteLine($"There are {LearningArrays.GradingScores.Count()} items in the list.");
			foreach (var score in LearningArrays.GradingScores) {
				Console.WriteLine($"A score is {score}");
			}

			LearningArrays.HighTemps.Add(65);
			LearningArrays.HighTemps.Add(63);
			LearningArrays.HighTemps.Add(81);
			LearningArrays.HighTemps.Add(86);
			LearningArrays.HighTemps.Add(77);
			LearningArrays.HighTemps.Add(69);
			LearningArrays.HighTemps.Add(71);
			LearningArrays.HighTemps.Add(76);
			LearningArrays.HighTemps.Add(74);
			LearningArrays.HighTemps.Add(74);
			LearningArrays.HighTemps.Add(72);
			Console.WriteLine($"The highest temperature is {LearningArrays.HighTemps.Max()}");
			Console.WriteLine($"The avg high temperature is {LearningArrays.HighTemps.Average()}");

			
			/*storing an array
			var scores = {1,2,3}
			var scores = new int [10] -- better if u know exactly how many items will be in your array
			var scores = new List<int>(); --defines a dynamic array list which can be changed
			BowlingGame[2] = 30; ???
			*/


		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
