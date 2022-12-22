using System;
using Calculateur;

namespace Projet
{
	class Program {
		static void Main(string[] args) {
			Console.WriteLine("------------------------------------------------------");
			Console.WriteLine("-----------Bienvenue sur ma Calculatrice -------------");
			Console.WriteLine("------------------------------------------------------");

			List<int> myArr = UserNumbers();

			int add = Operation("add", myArr);
			int multi = Operation("multi", myArr);
			int moy = Operation("moy", myArr);
			int racine = Operation("racine", myArr);

			Console.WriteLine($"La somme est: {add}");
			Console.WriteLine($"Le produit est: {multi}");
			Console.WriteLine($"La Moyenne est: {moy}");
			Console.WriteLine($"La Racine Carre est: {racine}");

			//end
			Console.ReadKey();
		}
		private static List<int> UserNumbers() {
			List<int> myList = new List<int>();
				
				Console.Write("Voulez-vous Entrer dans le Programe ? oui / non: ");
				string reponse = Console.ReadLine();

				while(reponse != "non") {
					Console.WriteLine("Veuillez entrer un nombre entier: ");
					int input = Convert.ToInt32(Console.ReadLine());
					myList.Add(input);
					
					Console.Write("Voulez-vous Continuer ? oui / non: ");
					reponse = Console.ReadLine();
				}

			return myList;
		}
		private static int Operation(string operation, List<int> myArr) {
			int result = 0;
			
			if(operation == "add") {
				result = Calculatrice.Addition(myArr);
			}
			if(operation == "multi") {
				result = Calculatrice.Multiplication(myArr);
			}
			if(operation == "moy") {
				result = Calculatrice.Moyenne(myArr);
			}
			if(operation == "racine") {
				 result = Convert.ToInt32(Calculatrice.RacineCarre(myArr));
			}
			return result;
		}
	}
}