// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");
Student i = new Student("Andrew", 20);
i.BecomeOlder();
i.WriteInfo();
class Student
{
    private string _name { get; set; }
    public int age { get; set; }
    public Student(string name)
    {
        this._name = name;
    }
    public Student (string name, int age)
    {
        this._name = name;
        this.age = age;
    }
    public void WriteInfo()
    {
        Console.WriteLine($"Имя: {this._name}, Возраст: {this.age}");
    }
    public void BecomeOlder()
    {
        this.age++;
    }
}

  
