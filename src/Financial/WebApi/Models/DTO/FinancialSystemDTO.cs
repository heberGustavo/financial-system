using WebApi.Models.DTO.Base;

namespace WebApi.Models.DTO
{
	public class FinancialSystemDTO : BaseDTO
	{
		public int Mes { get; set; }
		public int Ano { get; set; }
		public int DiaFechamento { get; set; }
		public bool GerarCopiaDespesa { get; set; }
		public int MesCopia { get; set; }
		public int AnoCopia { get; set; }
	}
}
