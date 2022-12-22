using System;

namespace Calculateur
{
	class Calculatrice {
		public Calculatrice() {
			Console.WriteLine("La classe Calculatrice evoquer");
		}

		public static int Addition(List<int> arr) {
			int result = 0;
			foreach(int element in arr) {
				result += element;
			}
			return result;
		}
		public static int Multiplication(List<int> arr) {
			int result = 1;
			foreach(int element in arr) {
				result *= element;
			}
			return result;
		}
		public static int Moyenne(List<int> arr) {
			int result = 0;
			result = Addition(arr) / arr.Count;
			return result;
		}
		public static double RacineCarre(List<int> arr) {
			int result = 0;
			result = Convert.ToInt32(Math.Sqrt(Multiplication(arr)));
			
			return result;
		}
		public static double ValeurAbsolue(List<int> arr) {
			int result = 0;
			result = Convert.ToInt32(Math.Abs(Multiplication(arr)));
			
			return result;
		}
		
	}
}