/*1. Tạo abstract class Person gồm Id, FullName, Email.
2. Tạo class Student kế thừa Person.
3. Tạo class Teacher kế thừa Person.
4. Tạo method DisplayRole() trong từng class con.
5. Tạo List<Person> chứa cả Student và Teacher rồi gọi DisplayInfo()
*/
using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

Student s1 = new Student("1111","hug","gmail.com","DA23TTa",6.7);
Teacher T1 = new Teacher("11134","hu232","gmail34.com","DA23TTC", "IT");
s1.DisplayRole();
T1.DisplayRole();

public abstract class Person
{
    public string? Id {get; set;}
    public string? FullName {get; set;}
    public string? Email {get; set;}

    public Person(string id, string fullname, string email)
    {
        Id = id;
        FullName = fullname;
        Email = email;
    }
    public abstract void DisplayRole();
}

public class Student : Person
{
    public string? ClassName {get; set;}
    public double Score {get; set;}

    public Student(string id, string fullname, string email, string classname, double score) : base(id, fullname, email) 
    {
        ClassName = classname;
        Score = score;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"name: {FullName}, student");
    }
}

public class Teacher : Person
{
    public string? ClassName {get; set;}
    public string Derparment {get; set;}

    public Teacher(string id, string fullname, string email, string classname, string derparment) : base(id, fullname, email) 
    {
        ClassName = classname;
        Derparment = derparment;
    }

    public override void DisplayRole()
    {
        Console.WriteLine($"name: {FullName}, teacher");
    }
}


