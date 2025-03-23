using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogroconiumGame.Models
{
	/// <summary>
	/// Комната 
	/// </summary>
	public class Room
	{
		/// <summary>
		/// Идентификатор для LiteDb
		/// </summary>
		[LiteDB.BsonId]
		public int Id { get; set; }

		/// <summary>
		/// Дата создания комнаты
		/// </summary>
		public int DateCreated { get; set; }

		/// <summary>
		/// Комманды которые играют в данной комнате
		/// </summary>
		public IEnumerable<Team> Teams { get; set; }
	}
}
