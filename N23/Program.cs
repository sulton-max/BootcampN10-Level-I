using N23;

var numbers = new List<int>()
{
    1,
    2,
    3,
    4,
    5
};

// Static queries
// public static class Queries
// {
//     public static bool IsOdd(int number)
//     {
//         return number % 2 != 0;
//     }
// }
//
// var oddNumbersQuery = numbers.AsEnumerable();
//
// oddNumbersQuery.Where(number => number % 2 != 0);

//
// var oddNumbers = numbers.Where(number =>
//     {
//         return number % 2 != 0;
//     })
//     .Order();
//
// foreach(var number in oddNumbers)
//     Console.WriteLine(number);
//
// numbers.Add(-1);
// numbers.Add(13);
// Console.WriteLine("Yangi son qo'shildi");
//
// foreach(var number in oddNumbers)
//     Console.WriteLine(number);
//
// Console.WriteLine("Dastur tugadi")

// var collection = new CustomQueryableCollection<int>();
// collection.Add(1);
// collection.Add(3);
// collection.Add(6);
// collection.Add(7);
// collection.Add(89);
//
// var oddNumbers = collection.Where(number => number % 2 != 0);
//
// foreach(var item in oddNumbers)
//     Console.WriteLine(item);
//
// collection.Add(-1);
// collection.Add(13);
// Console.WriteLine("Yangi son qo'shildi");
// Console.WriteLine();
//
// foreach(var item in oddNumbers)
//     Console.WriteLine(item);

// var newOddNumbers = collection.Where(number => number % 2 != 0);

#region Extension methods

var questions = new List<Question>()
{
    new Question("What is property", false, true),
    new Question("What is field", false, true),
    new Question("What is property", true, false)
};

// Any
var isThereAnySkippedQuestions = questions.Any(question => question.IsSkipped);
Console.WriteLine($"isThereAnySkippedQuestions - {isThereAnySkippedQuestions}");

// All
var isAllAnsweredRight = questions.All(question => question.IsRightAnswer);
Console.WriteLine($"isAllAnsweredRight - {isAllAnsweredRight}");

// Contains
var question = new Question("test", false, false);
var contains = questions.Contains(question);
Console.WriteLine($"contains - {contains}");







namespace N23
{
    public class Question
    {
        public string Text { get; set; }
        public bool IsSkipped { get; set; }
        public bool IsRightAnswer { get; set; }

        public Question(string text, bool isSkipped, bool isRightAnswer)
        {
            Text = text;
            IsSkipped = isSkipped;
            IsRightAnswer = isRightAnswer;
        }
    }
}

#endregion



//
//
// public record User(Guid Id, string FirstName, string LastName, bool IsActive);
//
// public record Question(Guid Id, string answers, byte rightAnswerIndex);
//
// public record Answer(Guid Id, Guid UserId, Guid QuestionId, byte rightAnswerIndex);
//
// public class DataSource
// {
//     public List<User> Users { get; init; } = new();
//     public List<Question> Questions { get; init; } = new();
//     public List<Answer> Answers { get; init; } = new();
// }
//
// public class AssessmentService
// {
//     private readonly DataSource _dataSource;
//
//     public AssessmentService(DataSource dataSource)
//     {
//         _dataSource = dataSource;
//     }
//
//     public Answer? GetAnswerById(Guid answerId)
//     {
//         return _dataSource.Answers.FirstOrDefault(x => x.Id == answerId);
//     }
//
//     public Question? GetQuestionById(Guid questionId)
//     {
//         return _dataSource.Questions.FirstOrDefault(x => x.Id == questionId);
//     }
//
//     public List<Answer> GetAnswersByUserId(Guid userId)
//     {
//         return _dataSource.Questions.Where(question => question.)
//     }
//
//     public List<Question> GetQuestions()
//     {
//         return _dataSource.Questions;
//     }
//
//     public List<Question> GetQuestions(Guid userId)
//     {
//         var answers = GetAnswersByUserId(userId);
//         var questions = GetQuestions();
//
//         var questionsIds = answers.Select(x => x.QuestionId).ToList();
//
//         return questions.Where(x => !questionsIds.Contains(x.Id)).ToList();
//     }
//
//     public List<Question> GetQuestions(Guid userId, int count)
//     {
//         var questions = GetQuestions(userId);
//
//         return questions.Take(count).ToList();
//     }
//
//     public void AddAnswer(Guid userId, Guid questionId, byte rightAnswerIndex)
//     {
//         var answer = new Answer(Guid.NewGuid(), userId, questionId, rightAnswerIndex);
//         _dataSource.Answers.Add(answer);
//     }
// }