using GameHub.Entities;
using System;

namespace GameHub
{
	class Program
	{
		public static void Main(string[] args)
		{

			Tabuleiro tabuleiro = new Tabuleiro(3, 3);

			tabuleiro.MostrarTabuleiro();

		}
	}
}
