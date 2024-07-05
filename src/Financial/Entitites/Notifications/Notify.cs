using System.ComponentModel.DataAnnotations.Schema;

namespace Entitites.Notifications
{
	public class Notify
	{
		#region Constructor

		public Notify()
		{
			Notificacoes = new List<Notify>();
		}

		#endregion

		[NotMapped]
		public string NomePropriedade { get; set; }
		
		[NotMapped]
		public string Mensagem { get; set; }
		
		[NotMapped]
		public List<Notify> Notificacoes;

		#region Public Methods

		public bool ValidPropertyString(string valor, string nomePropriedade)
		{
			if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				Notificacoes.Add(new Notify
				{
					Mensagem = "Campo Obrigatório",
					NomePropriedade = nomePropriedade
				});

				return false;
			}

			return true;
		}

		public bool ValidPropertyInt(int valor, string nomePropriedade)
		{
			if (valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
			{
				Notificacoes.Add(new Notify
				{
					Mensagem = "Campo Obrigatório",
					NomePropriedade = nomePropriedade
				});

				return false;
			}

			return true;

		}

		#endregion

	}
}