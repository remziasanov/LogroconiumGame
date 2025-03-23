using LiteDB;
using LogroconiumGame.Models.QuestionAnswer;
using LogroconiumGame.Repository.DbContext;

namespace LogroconiumGame.Repository
{
	/// <summary>
	/// Репозиторий наполнения вопросов
	/// </summary>
	public class QuestionsRepository
	{
		private LiteDatabase _liteDb;
		public QuestionsRepository(LiteDbContext liteDbContext)
		{
			_liteDb = liteDbContext.Database;
			InsertQuestions();
		}

		/// <summary>
		/// Наполнение вопросов 
		/// </summary>
		private void InsertQuestions()
		{
			// Создание списка вопросов 
			var question = new List<Question>() 
			{
				new Question
				{
					Text = "Какой язык программирования используется в ASP.NET?",
					AnswerOptions = new List<AnswerOption>
					{
						new AnswerOption { OptionText = "Java" },
						new AnswerOption { OptionText = "C#" },
						new AnswerOption { OptionText = "Python" },
						new AnswerOption { OptionText = "PHP" }
					},
					CorrectAnswerIndex = 1
				}, 
				new Question
				{

					Text = "Какой язык программирования используется в ASP.NET?",
					AnswerOptions = new List<AnswerOption>
					{
						new AnswerOption { OptionText = "Java" },
						new AnswerOption { OptionText = "C#" },
						new AnswerOption { OptionText = "Python" },
						new AnswerOption { OptionText = "PHP" }
					},
					CorrectAnswerIndex = 1
				}

			};


			var questionTable = _liteDb.GetCollection<Question>("questions");

			// Добавление вопроса в коллекцию
			questionTable.InsertBulk(question);

		}
	}
}
