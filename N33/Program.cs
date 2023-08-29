var users = new List<object>().Where(x => true).Select(user => user).Order().Take(10).ToList();

// using N33;

// var users = UserService.GetUsers();