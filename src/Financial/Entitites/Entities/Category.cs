using Entitites.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites.Entities
{
	[Table("TB_CATEGORY")]
	public class Category : BaseEntity
	{
		#region Foreign Keys

		[ForeignKey("FinancialSystem")]
		public int IdSistema { get; set; }
		public virtual FinancialSystem FinancialSystem { get; set; }

		#endregion
	}
}
