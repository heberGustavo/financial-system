using Domain.Interfaces;
using Domain.Interfaces.IServices;
using Entitites.Entities;

namespace Domain.Services
{
	public class FinancialSystemService : IFinancialSystemService
	{
		private readonly IFinancialSystem _financialSystem;

		public FinancialSystemService(IFinancialSystem financialSystem)
		{
			_financialSystem = financialSystem;
		}

		public async Task AddFinancialSystem(FinancialSystem financialSystem)
		{
			var valid = financialSystem.ValidPropertyString(financialSystem.Nome, "Nome");
			if (valid)
			{
				var data = DateTime.Now;

				financialSystem.DiaFechamento = 1;
				financialSystem.Ano = data.Year;
				financialSystem.Mes = data.Month;
				financialSystem.AnoCopia = data.Year;
				financialSystem.MesCopia = data.Month;
				financialSystem.GerarCopiaDespesa = true;

				await _financialSystem.Add(financialSystem);
			}

		}

		public async Task UpdateFinancialSystem(FinancialSystem financialSystem)
		{
			var valid = financialSystem.ValidPropertyString(financialSystem.Nome, "Nome");
			if (valid)
			{
				financialSystem.DiaFechamento = 1;
				await _financialSystem.Add(financialSystem);
			}
		}
	}
}
