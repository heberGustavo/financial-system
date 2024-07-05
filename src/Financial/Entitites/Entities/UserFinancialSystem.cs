using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites.Entities
{
    [Table("TB_USER_FINANCIAL_SYSTEM")]
	public class UserFinancialSystem
	{
		public int Id { get; set; }
        public string EmailUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool SistemaAtual { get; set; }

        #region Foreign Keys
        
        [ForeignKey("FinancialSystem")]
        public int IdSistema { get; set; }
        public virtual FinancialSystem FinancialSystem { get; set; }

        #endregion
    }
}
