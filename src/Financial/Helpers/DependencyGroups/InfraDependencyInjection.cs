using Domain.Interfaces.Generics;
using Infra.Repository.Generics;
using Microsoft.Extensions.DependencyInjection;

namespace Helpers.DependencyGroups
{
	public class InfraDependencyInjection
	{
		public static void Register(IServiceCollection services)
		{
			services.AddSingleton(typeof(IGeneric<>), typeof(RepositoryGeneric<>));
		}
	}
}
