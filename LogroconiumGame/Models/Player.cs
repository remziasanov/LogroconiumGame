namespace LogroconiumGame.Models
{
	/// <summary>
	/// Игрок команды или Ведущий
	/// </summary>
	public class Player
	{
		/// <summary>
		/// Идентификатор для LiteDb
		/// </summary>
		[LiteDB.BsonId]
		public int Id { get; set; }

		/// <summary>
		/// Имя игрока 
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Идентификатор игрока  телеграм 
		/// </summary>
		public int TelegramId { get; set; }

		/// <summary>
		/// Признак ведущий 
		/// </summary>
		public bool IsLeading { get; set; }
	}
}
