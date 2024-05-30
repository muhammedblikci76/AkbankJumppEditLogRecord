// See https://aka.ms/new-console-template for more information
using AkbankJumpp.OOPConsole.Entities;
using AkbankJumpp.OOPConsole.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;




//var Student = new Student()
//{
//    Id = Guid.NewGuid(),
//    FirstName = "muhammed",
//    LastName = "balıkçı",
//    Gender = Gender.Male,
//    No = 1,
//    CreatedOn = DateTimeOffset.Now,
//    RegistirationDate = DateTimeOffset.Now.AddHours(-1),
//};

//var SecondStudent = new Student()
//{
//    Id = Guid.NewGuid(),
//    FirstName = "alper",
//    LastName = "tunga",
//    Gender = Gender.Male,
//    No = 2,
//    CreatedOn = DateTimeOffset.Now,
//    RegistirationDate = DateTimeOffset.Now.AddHours(-1),
//};


//List<Student> students = new List<Student>();

//students.Add(Student);
//students.Add(SecondStudent);

//students.ForEach(x => Console.WriteLine("öğrenci bilgileri :" + x.No + " " + x.FirstName + " " + x.LastName + " " + x.Gender));









//for AccescontrolLog
var filePath = "C:\\Users\\USER\\Desktop\\AccesLog.txt";
var textFile=File.ReadAllText(filePath);

var splittedLines = textFile.Split("\r\n",StringSplitOptions.RemoveEmptyEntries);


//1--FRNM3121049C--FACE--2023-08-09T09:04:45+00:00

List<AccesControlLog> logs= new ();

foreach (var spletedLine in splittedLines)
{
    var values =spletedLine.Split("--",StringSplitOptions.RemoveEmptyEntries);

    var accesControlLog = new AccesControlLog()
    {
        Id = Guid.NewGuid(),
        CreatedOn = DateTimeOffset.Now,
        PersonId = Convert.ToInt64(values[0]),
        DeviceSerialNo = values[1],
        accesType = AccesControlLog.ConvertStringToAccesType(values[2]),
        LogTime = Convert.ToDateTime(values[3]),

    };
    logs.Add(accesControlLog);
}

File.WriteAllText("C:\\Users\\USER\\Desktop\\AccesLogJson.txt",JsonSerializer.Serialize( logs));
Console.WriteLine("opretion was successfuly was completed");

//Console.WriteLine(JsonSerializer.Serialize(logs));

//var AccesControlLog = new AccesControlLog()
//{
//    Id = Guid.NewGuid(),
//    PersonId = 1,
//    DeviceSerialNo = "dwfgsd",
//    accesType=0,

//};



Console.ReadLine();

