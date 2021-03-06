﻿using MeuPonto.Models;
using NUnit.Framework;
using System;
using System.Linq;

namespace MeuPonto.Tests
{
	[TestFixture]
	public class PeriodoTest
	{
		const int ano = 2014;
		const int mes = 8;
		const int dia = 25;

		[SetUp]
		public void Init()
		{
		}

		[Test]
		public void TotalHorasNormaisTrabalhadas1()
		{
			Assert.AreEqual(new TimeSpan(1, 18, 21, 0, 0), MockValues.PeriodosMock.FirstOrDefault().TotalHorasNormaisTrabalhadas);
		}

		[Test]
		public void TotalHorasNoturnasTrabalhadas1()
		{
			Assert.AreEqual(new TimeSpan(9, 49, 0), MockValues.PeriodosMock.FirstOrDefault().TotalHorasNoturnasTrabalhadas);
		}

		[Test]
		public void TotalHorasTotais()
		{
			var totalHorasNormaisTrabalhadas = MockValues.PeriodosMock.FirstOrDefault().TotalHorasNormaisTrabalhadas;
			var totalHorasNoturnasTrabalhadas = MockValues.PeriodosMock.FirstOrDefault().TotalHorasNoturnasTrabalhadas;
			Assert.AreEqual(new TimeSpan(2, 4, 10, 0, 0), totalHorasNormaisTrabalhadas.Add(totalHorasNoturnasTrabalhadas));
		}
	}
}