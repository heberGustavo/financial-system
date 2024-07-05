using Entitites.Notifications;
using System.ComponentModel.DataAnnotations;

namespace Entitites.Entities.Base
{
	public class BaseEntity : Notify
	{
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
