using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
	public class LearningArrays {
		public static string[] Students = { "a", "b", "c", "d", "e" };

		public static int[] TestScores = { 95, 87, 99, 92 };

		public static int[] Frames = { 23, 8, 23, 15, 11, 10, 3, 12, 15, 13 };

		// multi-dimensional arrays
		public static int[,] BowlingScores = new int[,] {
			{23, 8, 23, 15, 11, 10, 3, 12, 15, 13 }, //first game
			{8, 12, 14, 30,  0, 12,  6, 15,  16,  0}, //second game
			{27, 18,  5, 24, 11,  17,  0, 19,  6, 2} //third game
	};

		public static List<int> GradingScores = new List<int>();

		public static List<int> HighTemps = new List<int>();


	}
}
// { 23, 8, 23, 15, 11, 10, 3, 12, 15, 13}