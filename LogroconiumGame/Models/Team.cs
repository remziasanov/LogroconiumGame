namespace LogroconiumGame.Models
{
	/// <summary>
	/// Команда игрока
	/// </summary>
	public class Team
	{
		/// <summary>
		/// Идентификатор для LiteDb
		/// </summary>
		[LiteDB.BsonId]
		public int Id { get; set; }

		/// <summary>
		/// Номер комманды (не уникальный номер) 
		/// </summary>
		public int Number { get; set; }

		/// <summary>
		/// Название комманды 
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// Игроки комманды
		/// </summary>
		public IEnumerable<Player> Players { get; set; }
	}
}
