using System.Text;
using System.Text.RegularExpressions;
using N16.ReadOnlyProperty;
using N16.ReadWriteProperty;

#region OOP Intro 

// All property types

// Read-write property
// auto-property - public string FirstName { get; set; }   
// standard read-write property - public string FirstName { get => _firstName; set => _firstName = value; }
var user = new User();

user.FirstName = "Test";
//user.LastName = ""; // invalid - throws exception

// Read-only property
// readonly property - public string FirstName { get => _firstName; }
// expression bodied readonly property - public string FirstName => _firstName;
var sender = new EmailSender("");
//sender.FromAddress = "test@gmail.com"; // invalid - can't change read-only property


// Write-only property
var writeOnlyUser = new N16.Write_Only_Property.User();
writeOnlyUser.Password = "Test";

// Init-only property
var initOnlyUser = new N16.InitOnlyProperty.User("")
{
    Name = "Test",
};

//initOnlyUser.Name = ""; // invalid
Console.WriteLine(initOnlyUser.Name);


//initOnlyUser.Name = "Test"; // invalid - can't set init only property


// user.DoSomething(valueB: 10, valueA: 20);

// All method parameters

// params paramter

// method signature

// All type types ( abstract, sealaed, static )

// Static members

// Abstract and Interface

#endregion

#region Encapsulation



#endregion