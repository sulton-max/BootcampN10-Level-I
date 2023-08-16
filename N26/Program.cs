var valueA = 10;
var valueB = 20;
var valueC = valueA + valueB;


// Operator overloadingdan nimaga ehtiyot bo'lib ishlatish kerak?
//
// var person = null as LoginModel;
// person = new Admin();
//
// // Checking if person valid
// if (person)
// {
//
// }
//
// public class LoginModel
// {
//     public static bool operator true(LoginModel user)
//     {
//
//     }
//
//     public static bool operator false(LoginModel user)
//     {
//
//     }
// }
//
//
// public class Admin : LoginModel
// {
//     // public static LoginModel operator <(LoginModel userA, LoginModel userB)
//     // {
//     //     return new LoginModel();
//     // }
//     //
//     // public static bool operator >(LoginModel userA, LoginModel userB)
//     // {
//     //     return true;
//     // }
//     //
//     // public static bool operator +(LoginModel userA)
//     // {
//     //     return true;
//     // }
// }

var tasks = new List<TaskItem>()
{
    new("Finish course", 4),
    new("Sprint planning", 5),
    new("PR review", 6)
};

for (var indexA = 0; indexA < tasks.Count - 1; indexA++)
for (var indexB = indexA + 1; indexB < tasks.Count; indexB++)
    if (tasks[indexA] < tasks[indexB])
        (tasks[indexA], tasks[indexB]) = (tasks[indexB], tasks[indexA]);

tasks.ForEach(Console.WriteLine);

var loginModel = new LoginModel("test@gmail.com", "456789");
if (!loginModel)
    loginModel.GetErrors().ForEach(Console.WriteLine);
