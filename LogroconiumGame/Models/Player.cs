using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogroconiumGame.Models
{
	/// <summary>
	/// Игрок команды
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Идентификатор для LiteDb
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Имя игрока 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Идентификатор игрока  телеграм 
		/// </summary>
		public int TelegramId { get; set; }
	}
}
