using System;
using System.Globalization;
namespace Mybank {
	class Program {
		static void Main(string[] args) {
			Conta conta = new Conta();
			conta.Saldo = 500.00;
			Console.WriteLine("Bem-vind@ ao FranceBank!");
			Console.WriteLine(" ");

			while (conta.Saldo > 0) {
				
				Console.WriteLine("------------------------------------------");
				Console.WriteLine("Menu de Opções: ");
				Console.WriteLine("° 1 Depósitos ");
				Console.WriteLine("° 2 Saques ");
				Console.WriteLine("° 3 Consulta de Saldo ");
				Console.WriteLine("------------------------------------------");
				Console.Write("* Digite a opção desejada: ");
				int option = int.Parse(Console.ReadLine());
				Console.WriteLine(" ");
				double qte;
				if (option == 1) {
					Console.Write("* Digite a quantia que deseja depositar: ");
					qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					conta.Adcsaldo(qte);
					Console.WriteLine(" ");
					Console.WriteLine("*** Depósito efetuado com sucesso! ***");
                    
					Console.WriteLine(" ");

				} else if (option == 2) {
					Console.Write("* Digite a quantia que deseja sacar: ");
					qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
					conta.removersaldo(qte);
					Console.WriteLine(" ");
					Console.WriteLine("*** Saque realizado com sucesso! ***");
                    Console.WriteLine(" "); 

				} else if (option == 3) {
						Console.WriteLine(conta);
				} else {
                    Console.WriteLine("* Opção invalida, para continuar digite 1, 2 ou 3.");
					Console.WriteLine(" ");
				}
			}
			Console.WriteLine("FranceBank, agradece a sua preferencia!");


		}
	}
}



