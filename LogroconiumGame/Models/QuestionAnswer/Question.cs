namespace LogroconiumGame.Models.QuestionAnswer
{
	/// <summary>
	/// Вопрос 
	/// </summary>
	public class Question
	{
		/// <summary>
		/// Идентификатор  вопроса для LiteDb
		/// </summary>
		[LiteDB.BsonId]
		public int Id { get; set; }

		/// <summary>
		/// Текст вопрос
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Список вариантов ответов
		/// </summary>
		public List<AnswerOption> AnswerOptions { get; set; }

		/// <summary>
		/// Индекс правильного ответа в списке вариантов
		/// </summary>
		public int CorrectAnswerIndex { get; set; } 
	}
}
