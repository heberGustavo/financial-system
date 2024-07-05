using Entitites.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites.Entities
{
    [Table("TB_FINANCIAL_SYSTEM")]
	public class FinancialSystem : BaseEntity
	{
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int DiaFechamento { get; set; }
        public bool GerarCopiaDespesa { get; set; }
        public int MesCopia { get; set; }
        public int AnoCopia { get; set; }
    }
}
