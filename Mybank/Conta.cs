using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;


namespace Mybank {
	internal class Conta {
		public double Saldo;

		public override string ToString() {
			return $"Saldo Atual: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
		}

		public void Adcsaldo(double saldo) {
			Saldo += saldo;

		}

		public void removersaldo(double saldo) {
			Saldo -= saldo;

		}
	}
}