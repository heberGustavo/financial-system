using Entitites.Entities.Base;
using Entitites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites.Entities
{
	[Table("TB_EXPENSE")]
	public class Expense : BaseEntity
	{
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public TypeExpenseEnum TipoDespesa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Pago { get; set; }
        public bool DespesaAtrasada { get; set; }

		#region Foreign Keys

		[ForeignKey("Category")]
		public int IdCategoria { get; set; }
		public virtual Category Category { get; set; }

		#endregion
	}
}
